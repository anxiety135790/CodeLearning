using System;

class interfaceExplicitlmpl

    {
        static void Main()

            {

                FileViewer f = new FIleView();

                t.Test();

                ((IWindow)f).Close();

                IWindow w = new FileView();

                wClose();

            }
}

interface IWindow
    {
        void Close();

}

interface IFileHandler

{
    void Close();

}

class FileViewer:IWindow,IfilHandler

{
    void IWindow.Close()

        {

            Console.WriteLine("Window Closed");

        }

    void iFileHandler.Close()

        {

            Console.WriteLine("File Closed");

        }

    public void Test()

        {

            ((iWindow) this).Close();
        }

}
