using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RepairRequests
{
    public static class RequestRepository
    {
        private static readonly string _filePath = "requests.json";

        // Загрузка заявок из JSON-файла
        public static List<Request> LoadRequests()
        {
            if (File.Exists(_filePath))
            {
                try
                {
                    var json = File.ReadAllText(_filePath);
                    return JsonConvert.DeserializeObject<List<Request>>(json) ?? new List<Request>();
                }
                catch (Exception ex)
                {
                    // Log the exception if necessary
                    Console.WriteLine($"Error reading file: {ex.Message}");
                    return new List<Request>();
                }
            }
            return new List<Request>();
        }

        // Сохранение заявок в JSON-файл
        public static void SaveRequests(List<Request> requests)
        {
            try
            {
                var json = JsonConvert.SerializeObject(requests, Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                Console.WriteLine($"Error writing file: {ex.Message}");
            }
        }

        // Добавление новой заявки
        public static void AddRequest(Request request)
        {
            var requests = LoadRequests();
            request.RequestId = requests.Any() ? requests.Max(r => r.RequestId) + 1 : 1; // Уникальный ID
            requests.Add(request);
            SaveRequests(requests);
        }

        // Обновление заявки
        public static void UpdateRequest(Request updatedRequest)
        {
            var requests = LoadRequests();
            var existingRequest = requests.FirstOrDefault(r => r.RequestId == updatedRequest.RequestId);
            if (existingRequest != null)
            {
                // Обновляем только разрешённые поля
                existingRequest.DateAdded = updatedRequest.DateAdded;
                existingRequest.EquipmentType = updatedRequest.EquipmentType;
                existingRequest.Model = updatedRequest.Model;
                existingRequest.ProblemDescription = updatedRequest.ProblemDescription;
                existingRequest.ClientName = updatedRequest.ClientName;
                existingRequest.PhoneNumber = updatedRequest.PhoneNumber;

                // Save updated list back to the JSON file
                SaveRequests(requests);
            }
        }
    }
}
