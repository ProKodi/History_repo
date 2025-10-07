import java.awt.*;
import java.io.*;

public class DirList {
    public static void main(String args[]) {
        DirListFrame frame = new DirListFrame("DirList");
        frame.show();
    }
}

    class DirListFrame extends Frame
    {
        TextArea text = new TextArea();
        File dir;
        String[] dirList;
        File file;


        public DirListFrame(String str) {
            super(str);
            text.setEditable(false);

            add(text);

            dir = new File("c:");
            dirList = dir.list();

            for (String item: dirList)
            {
                file = new File(dir.getPath()+"\\"+item);
                if(file.isFile())
                {
                    String s = item.toUpperCase();
                    text.setText(text.getText() + s+"\r\n");
                }
                else
                {
                    String s = item.toLowerCase();
                    text.setText(text.getText() + s+"\r\n");
                }
            }
            resize(320, 240);
        }

        public boolean handleEvent(Event evt) {
            switch (evt.id) {
                case Event.WINDOW_DESTROY:
                    dispose();
                    System.exit(0);
                    return true;
                case Event.ACTION_EVENT:

                    return true;

                default:

                    return super.handleEvent(evt);
            }
        }
    }

