import java.awt.*;
import java.io.*;
import java.util.Objects;

public class StreamDemo
{
    public static void main(String args[])
    {
        MainFrame frame = new MainFrame("StreamDemo");
        frame.show();
    }

}



    class MainFrame extends Frame
    {
        TextArea text = new TextArea();
        public MainFrame(String str)
        {
            super (str);
            MenuBar menu = new MenuBar();
            Menu file = new Menu("File");
            file.add(new MenuItem("Open"));
            file.add(new MenuItem("Save File"));
            menu.add(file);
            setMenuBar(menu);
            this.add(text);
            resize(320,240);
        }

        public boolean handleEvent(Event evt)
        {
            switch (evt.id)
            {
                case Event.WINDOW_DESTROY:
                    dispose();
                    System.exit(0);
                    return true;
                case Event.ACTION_EVENT:
                    if(evt.target instanceof MenuItem)
                    {
                        String label = ((MenuItem)evt.target).getLabel();
                        System.out.println(label);
                        if(label.equals("Open"))
                        {
                            try
                            {

                                String ss = "";
                                StringBuilder s = new StringBuilder();
                                FileInputStream file = new FileInputStream("out.txt");

                                BufferedReader reader = new BufferedReader(new InputStreamReader(file));
                                String line = reader.readLine();
                                while(line != null)
                                {
                                    s.append(line);
                                    line = reader.readLine();
                                }
                                text.setText(s.toString());
                                System.out.println("Stream close");
                                reader.close();

                            }
                            catch (IOException exception)
                            {
                                System.out.println("Exception");
                            }
                        }
                        else if(label.equals("Save File"))
                        {
                            try
                            {
                                FileOutputStream stream = new FileOutputStream("out.txt");
                                BufferedOutputStream bufferedOutputStream = new BufferedOutputStream(stream);
                                String text_1 = text.getText();
                                byte[] buffer = text_1.getBytes();

                                bufferedOutputStream.write(buffer);
                                bufferedOutputStream.flush();
                                bufferedOutputStream.close();
                                stream.close();

                            }
                            catch (IOException exception)
                            {

                            }
                        }
                        else return false;
                    }
                default:

                    return super.handleEvent(evt);
            }
        }
}
