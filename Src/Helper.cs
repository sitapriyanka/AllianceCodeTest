using System;
using System.IO;

namespace Tests
{
    public static class Helper
    {
        /// <summary>
        ///Construct file path using filename and directoryName
        /// </summary>
        /// <param "fileName">The file path to write the object instance to.</param>
        /// <param "directoryName">The object instance to write to the file.</param>
        public static string ConstructFilePath(string fileName, string directoryName)
        {
            if (fileName == null || directoryName == null) throw new ArgumentNullException();
            return string.Format(@".\{0}\", directoryName) + fileName + ".txt";
        }

        /// <summary>
        ///Create directory if it is not existing.
        /// </summary>
        /// <param "directoryName">Directory name.</param>
        public static void CreateDirectoryIfNotExists(string directoryName)
        {
            if (directoryName == null) throw new ArgumentNullException();
            if (!Directory.Exists(directoryName)) Directory.CreateDirectory(directoryName);
        }

        /// <summary>
        ///Create new GUID and return it.
        /// </summary>
        public static string GetNewId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
