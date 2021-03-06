﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace kTesterAdmin.Model
{
    class Settings
    {
        private static Settings instance;

        /// <summary>
        /// Путь настроек программы
        /// </summary>
        private static string SETTINGS_PATH = Path.Combine(System.Environment.CurrentDirectory, "settings.json");

        public string Ip { get; set; }
        public int Port { get; set; }
        private Settings() { }

        public static Settings GetSettings()
        {
            if (instance == null)
            {
                if (!Load())
                {
                    instance = new Settings();
                    instance.Ip = "127.0.0.1";
                    instance.Port = 8005;
                    Save();
                }
            }
            return instance;
        }

        /// <summary>
        /// Сохранение объекта настроек
        /// </summary>
        public static void Save()
        {
            string json = JsonConvert.SerializeObject(instance, Formatting.Indented);
            File.WriteAllText(SETTINGS_PATH, json, Encoding.UTF8);
        }

        /// <summary>
        /// Загрузка настроек программы
        /// </summary>
        /// <returns>Возвращает true, если объект настроек загружен успешно</returns>
        private static bool Load()
        {
            if (!File.Exists(SETTINGS_PATH)) return false;

            string data = File.ReadAllText(SETTINGS_PATH, Encoding.UTF8);
            instance = JsonConvert.DeserializeObject<Settings>(data);
            return (instance != null);
        }
    }
}
