﻿namespace PgSqlMigrator_Core
{
    /// <summary>
    /// Класс кодирования информации
    /// </summary>
    public class InfoCoder
    {
        /// <summary>
        /// Метод для шифрования строки
        /// </summary>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <returns>Зашифрованная строка</returns>
        public static string Incode(string input, string key)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += (char)(input[i] * key[i % key.Length]);
            }
            return output;
        }

        /// <summary>
        /// Медот дешифровки строки
        /// </summary>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <returns>Расшифрованная строка</returns>
        public static string Decode(string input, string key)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += (char)(input[i] / key[i % key.Length]);
            }
            return output;
        }
    }
}