using System;
using System.IO;
using System.Windows.Forms;

public class Program : Form
{
    [STAThread]
    public static void Main(string[] args)
    {
        //Вывести информацию о файле
        var file = new OpenFileDialog // создаём диалоговое окно для выбора файла
        {
            //открыть много файлов
            Multiselect = false,
            //фильтр по расширению
            Filter = "Text files (*.*)|*.*|All files (*.*)|*.*"

        };

        if (file.ShowDialog() != DialogResult.OK) //закрываем программу если диалоговое окно с выбором базы было закрыто
            return;
        //Вывести информацию о файле
        var fileInfo = new FileInfo(file.FileName);
        Console.WriteLine("Имя файла: {0}", fileInfo.Name);
        Console.WriteLine("Расширение: {0}", fileInfo.Extension);
        Console.WriteLine("Полный путь: {0}", fileInfo.FullName);
        Console.WriteLine("Размер: {0}", fileInfo.Length);
        Console.WriteLine("Дата создания: {0}", fileInfo.CreationTime);
        Console.WriteLine("Дата последнего изменения: {0}", fileInfo.LastWriteTime);
        Console.WriteLine("Дата последнего доступа: {0}", fileInfo.LastAccessTime);
        Console.WriteLine("Доступен для записи: {0}", fileInfo.IsReadOnly);
        Console.ReadKey();
    }
}