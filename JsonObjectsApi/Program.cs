using System;
using Classes.JsonObjectApi;
using System.Collections.Generic;
using System.Linq;

namespace JsonObjectsApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution();
        }

        #region SOLUTION
        static void Solution()
        {
            // List<JsonObjectViewModel> objects = await client.GetStringAsync("api address");
        }

        static List<JsonObjectViewModel> Match(List<JsonObjectViewModel> objects, string searchTerm)
        {
            List<JsonObjectViewModel> returnObjects = new List<JsonObjectViewModel>();
            foreach(JsonObjectViewModel item in objects)
                if(item.Content.Contains(searchTerm))
                    returnObjects.Add(item);
                
            return returnObjects;
        }

        static List<JsonObjectViewModel> Sort(List<JsonObjectViewModel> objects, string orderType, string selectedDate)
        {
            List<JsonObjectViewModel> returnObjects = new List<JsonObjectViewModel>();
            if(orderType == "ASC")
                if(selectedDate == "CreatedDate")
                    returnObjects.AddRange(objects.OrderBy(item => item.CreatedDate));
                else
                    returnObjects.AddRange(objects.OrderBy(item => item.ModifiedDate));
            else
                if(selectedDate == "CreatedDate")
                    returnObjects.AddRange(objects.OrderByDescending(item => item.CreatedDate));
                else
                    returnObjects.AddRange(objects.OrderByDescending(item => item.ModifiedDate));

            return returnObjects;
        }

        static List<JsonObjectViewModel> Modify(List<JsonObjectViewModel> objects, string itemId, string newContent)
        {
            foreach(JsonObjectViewModel item in objects)
                if(item.Id == itemId)
                    item.Content = newContent;

            return objects;
        }
        #endregion
    }
}
