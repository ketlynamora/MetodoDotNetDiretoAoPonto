using System;
using System.IO;

namespace NetDiretoAoPonto.TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Directory e DirectoryInfo

            var folderName = "pasta";
            var subFolderName = "subpasta";
            var subFolderNameStatic = "subpasta_usingstatic";

            var directoryInfoSubFolder = new DirectoryInfo(subFolderName);

            if (!Directory.Exists(folderName) || directoryInfoSubFolder.Exists)
            {
                Directory.CreateDirectory(subFolderNameStatic);
                Directory.CreateDirectory(folderName);
                directoryInfoSubFolder.Create();

                directoryInfoSubFolder.MoveTo($"{folderName}//{subFolderName}");
                Directory.Move(subFolderNameStatic, $@"{folderName}\{subFolderNameStatic}");
            }

            var name = directoryInfoSubFolder.Name;
            var parent = directoryInfoSubFolder.Parent;
            var root = directoryInfoSubFolder.Root;
            var exists = directoryInfoSubFolder.Exists;

            foreach (var directory in Directory.GetDirectories(folderName))
            {
                Console.WriteLine(directory);
            }

            Directory.Delete($@"{folderName}\{subFolderName}");

            #endregion

            #region File e FileInfo

            var file = @"pasta\text.txt";

            if (!File.Exists(file))
                File.Create(file);

            var fileInfo = new FileInfo(file);

            Console.WriteLine($"Nome: {fileInfo.Name}, Tamanho: {fileInfo.Length}, Data de atualização: {fileInfo.LastWriteTime}");

            #endregion

            Console.ReadKey();
        }
    }
}
