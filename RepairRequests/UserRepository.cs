using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RepairRequests
{
    public static class UserRepository
    {
        private static readonly string _filePath = "users.json";
        private static readonly string _sessionFile = "current_user.json"; // Файл для хранения текущего пользователя
        private static User _currentUser;

        // Загрузка пользователей из JSON-файла с обработкой ошибок
        public static List<User> LoadUsers()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    var json = File.ReadAllText(_filePath);
                    return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке пользователей: {ex.Message}");
            }
            return new List<User>();
        }

        // Сохранение пользователей в JSON-файл с обработкой ошибок
        public static void SaveUsers(List<User> users)
        {
            try
            {
                var json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении пользователей: {ex.Message}");
            }
        }

        // Поиск пользователя по логину и паролю
        public static User FindUser(string login, string password)
        {
            try
            {
                var users = LoadUsers();
                return users.FirstOrDefault(u => u.Login == login && u.Password == password);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при поиске пользователя: {ex.Message}");
            }
            return null;
        }

        // Установка текущего пользователя
        public static void SetCurrentUser(User user)
        {
            try
            {
                _currentUser = user;
                var userJson = JsonConvert.SerializeObject(user);
                File.WriteAllText(_sessionFile, userJson);
                Console.WriteLine("Текущий пользователь сохранен в файл: " + _sessionFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении текущего пользователя: {ex.Message}");
            }
        }

        // Получение текущего пользователя
        public static User GetCurrentUser()
        {
            try
            {
                // Сначала проверяем, установлен ли текущий пользователь в памяти
                if (_currentUser != null)
                    return _currentUser;

                // Если нет, пытаемся загрузить его из файла
                if (File.Exists(_sessionFile))
                {
                    var json = File.ReadAllText(_sessionFile);
                    _currentUser = JsonConvert.DeserializeObject<User>(json);
                    return _currentUser;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке текущего пользователя: {ex.Message}");
            }

            return null; // Возвращаем null, если текущий пользователь не найден
        }

        // Добавление нового пользователя
        public static void AddUser(User user)
        {
            try
            {
                var users = LoadUsers();
                users.Add(user);
                SaveUsers(users);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавлении пользователя: {ex.Message}");
            }
        }

        // Выход пользователя
        public static void Logout()
        {
            try
            {
                _currentUser = null;
                if (File.Exists(_sessionFile))
                    File.Delete(_sessionFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при выходе пользователя: {ex.Message}");
            }
        }
    }
}
