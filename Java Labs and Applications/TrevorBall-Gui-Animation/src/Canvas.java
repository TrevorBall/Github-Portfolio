import java.awt.*;
import javax.swing.*;
import java.util.HashMap;

public class Canvas
{
    private static Canvas canvas;

    public static Canvas getCanvas()
    {
        if (canvas == null)
        {
            canvas = new Canvas();
        }
        return canvas;
    }

    private JFrame frame;
    private JPanel panel;
    private Image image;
    private Graphics2D g;
    private HashMap<String, Shape> shapes;

    private Canvas()
    {
        frame = new JFrame("Canvas");

        panel = new JPanel()
        {
            public void paintComponent(Graphics g2)
            {
                super.paintComponent(g2);
                g2.drawImage(image, 0, 0, null);
            }
        };

        panel.setPreferredSize(new Dimension(900, 550));
        frame.add(panel);
        frame.pack();
        frame.setVisible(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        image = panel.createImage(900, 550);
        g = (Graphics2D) image.getGraphics();

        shapes = new HashMap<>();
    }

    public void draw(String name, String color, Shape shape)
    {
        shapes.put(name, shape);
        g.setColor(getColor(color));
        g.fill(shape);
        panel.repaint();
    }

    public void drawText(String name, String text, int x, int y, int size, String color)
    {
        g.setColor(getColor(color));
        g.setFont(new Font("Arial", Font.BOLD, size));
        g.drawString(text, x, y);
        panel.repaint();
    }

    public void erase(String name)
    {
        Shape s = shapes.get(name);
        if (s != null)
        {
            g.setColor(Color.white);
            g.fill(s);
            panel.repaint();
        }
    }

    public void clear()
    {
        g.setColor(Color.white);
        g.fillRect(0, 0, 900, 550);
        panel.repaint();
    }

    public void wait(int time)
    {
        try
        {
            Thread.sleep(time);
        }
        catch (Exception e) {}
    }

    private Color getColor(String c)
    {
        if (c.equals("red")) return Color.red;
        if (c.equals("blue")) return Color.blue;
        if (c.equals("green")) return Color.green;
        if (c.equals("yellow")) return Color.yellow;
        if (c.equals("white")) return Color.white;
        if (c.equals("black")) return Color.black;
        if (c.equals("cyan")) return Color.cyan;
        if (c.equals("gray")) return Color.gray;
        if (c.equals("orange")) return Color.orange;
        if (c.equals("magenta")) return Color.magenta;
        if (c.equals("lightGray")) return Color.lightGray;

        return Color.black;
    }
}