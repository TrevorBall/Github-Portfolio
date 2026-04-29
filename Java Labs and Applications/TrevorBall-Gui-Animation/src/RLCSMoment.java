import javax.sound.sampled.*;
import java.io.File;
import java.awt.Rectangle;
import java.awt.Polygon;
import java.awt.geom.Ellipse2D;

public class RLCSMoment
{
    private Canvas canvas;

    public RLCSMoment()
    {
        canvas = Canvas.getCanvas();
    }

    public void play()
    {
        int ballX = 760;
        int ballY = 255;

        int carX = 500;
        int carY = 330;

        playAudio("rlcs_audio.wav");

        // first scene
        drawScene(ballX, ballY, carX, carY, "0:02", "NRG 2", "DIG 3");
        canvas.wait(2000);

        //ball goes up
        for (int i = 0; i < 60; i++)
        {
            ballY = 255 - (i * 2);

            String time = (i > 20) ? "0:01" : "0:02";

            drawScene(ballX, ballY, carX, carY, time, "NRG 2", "DIG 3");
            canvas.wait(100);
        }

        //car aerials
        for (int i = 0; i < 80; i++)
        {
            carX = 500 + (i * 3);
            carY = 330 - (i * 2);

            String time = (i > 50) ? "0:00" : "0:01";

            drawScene(ballX, ballY, carX, carY, time, "NRG 2", "DIG 3");
            drawBoost(carX, carY);

            canvas.wait(71);
        }

        // jstn touch
        for (int i = 0; i < 25; i++)
        {
            // car moves up/right toward the ball
            carX = 720 + (i * 2);
            carY = 145 + i;

            // ball comes down from ceiling toward front bumper
            ballX = 790 + i;
            ballY = 135 + (i * 4);

            if (ballX > 850)
            {
                ballX = 850;
            }

            if (ballY > 255)
            {
                ballY = 255;
            }

            drawScene(ballX, ballY, carX, carY, "0:00", "NRG 2", "DIG 3");
            drawBoost(carX, carY);

            canvas.wait(90);
        }

        drawScene(850, 255, carX, carY, "0:00", "NRG 2", "DIG 3");
        canvas.draw("flash", "yellow", new Rectangle(835, 220, 45, 110));
        canvas.wait(250);

        //ties game
        drawScene(850, 255, carX, carY, "0:00", "NRG 3", "DIG 3");
        canvas.drawText("ot", "OVERTIME", 320, 430, 40, "blue");

        for (int i = 0; i < 6; i++)
        {
            if (i % 2 == 0)
            {
                canvas.draw("bar1", "yellow", new Rectangle(90, 465, 220, 22));
                canvas.draw("bar2", "cyan", new Rectangle(580, 465, 220, 22));
            }
            else
            {
                canvas.draw("bar1", "magenta", new Rectangle(90, 465, 220, 22));
                canvas.draw("bar2", "white", new Rectangle(580, 465, 220, 22));
            }

            canvas.wait(160);
        }
    }

    private void drawScene(int ballX, int ballY, int carX, int carY,
                           String time, String leftScore, String rightScore)
    {
        canvas.clear();

        //background adn the field
        canvas.draw("sky", "cyan", new Rectangle(0, 0, 900, 140));
        canvas.draw("crowd1", "magenta", new Rectangle(0, 0, 900, 50));
        canvas.draw("crowd2", "black", new Rectangle(0, 50, 900, 45));
        canvas.draw("field", "green", new Rectangle(0, 155, 900, 395));

        //walls and lines
        canvas.draw("ceiling", "gray", new Rectangle(0, 155, 900, 5));
        canvas.draw("mid", "white", new Rectangle(445, 155, 10, 395));

        //goal
        canvas.draw("goal1", "white", new Rectangle(835, 220, 45, 110));
        canvas.draw("goal2", "black", new Rectangle(842, 227, 31, 96));

        //scoreboard
        canvas.draw("boardOuter", "black", new Rectangle(280, 15, 340, 60));
        canvas.draw("boardLeft", "blue", new Rectangle(290, 22, 110, 46));
        canvas.draw("boardMid", "white", new Rectangle(400, 22, 100, 46));
        canvas.draw("boardRight", "orange", new Rectangle(500, 22, 110, 46));

        canvas.drawText("score1", leftScore, 305, 52, 22, "white");
        canvas.drawText("score2", time, 430, 52, 22, "black");
        canvas.drawText("score3", rightScore, 517, 52, 22, "black");

        // ball
        canvas.draw("ball", "white", new Ellipse2D.Double(ballX, ballY, 26, 26));

        // added center dot to make it visible when it gets towards white line at the top
        canvas.draw("ballDot", "black", new Ellipse2D.Double(ballX + 8, ballY + 8, 10, 10));

        // car
        canvas.draw("carBody", "blue", new Rectangle(carX, carY, 70, 22));
        canvas.draw("carTop", "blue", new Rectangle(carX + 18, carY - 12, 28, 12));
        canvas.draw("wheel1", "black", new Ellipse2D.Double(carX + 8, carY + 16, 14, 14));
        canvas.draw("wheel2", "black", new Ellipse2D.Double(carX + 46, carY + 16, 14, 14));
    }

    private void drawBoost(int carX, int carY)
    {
        Polygon flame = new Polygon();
        flame.addPoint(carX, carY + 8);
        flame.addPoint(carX - 20, carY + 16);
        flame.addPoint(carX - 4, carY + 26);

        canvas.draw("boost", "yellow", flame);
    }

    private void playAudio(String filename)
    {
        try
        {
            File file = new File(filename);
            AudioInputStream audioStream = AudioSystem.getAudioInputStream(file);

            Clip clip = AudioSystem.getClip();
            clip.open(audioStream);
            clip.start();
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }
}