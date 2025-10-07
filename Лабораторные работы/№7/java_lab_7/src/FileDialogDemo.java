import java.awt.*;
import java.io.*;

public class FileDialogDemo {
    public static void main(String args[]) {
        DialogDemoFrame frame = new DialogDemoFrame("DialogDemo");
        frame.show();
    }
}

    class DialogDemoFrame extends Frame
    {
        TextArea text = new TextArea();
        String path = "";
        public DialogDemoFrame(String str)
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
                                FileDialog dialog = new FileDialog(this, "Open", FileDialog.LOAD);
                                dialog.setFile("*.txt");

                                dialog.show();
                                path = dialog.getDirectory()+dialog.getFile();

                                RandomAccessFile reader = new RandomAccessFile(new File(path), "r");
                                String line = reader.readLine();
                                while(line != null)
                                {
                                    s.append(line);
                                    s.append("\n");
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
                                FileDialog dialog = new FileDialog(this, "Open", FileDialog.SAVE);
                                dialog.setFile("*.txt");
                                dialog.show();
                                path = dialog.getDirectory()+dialog.getFile();

                                FileOutputStream stream = new FileOutputStream(path);
                                RandomAccessFile file = new RandomAccessFile(new File(path), "rw");
                                String text_1 = text.getText();
                                byte[] buffer = text_1.getBytes();
                                file.write(buffer);
                                //BufferedOutputStream bufferedOutputStream = new BufferedOutputStream(stream);
                                file.close();

                                //bufferedOutputStream.write(buffer);
                                //bufferedOutputStream.flush();
                                //bufferedOutputStream.close();
                                //stream.close();

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

