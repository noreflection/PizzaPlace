﻿using System;
using System.Collections;
using System.ComponentModel;

namespace PizzaStore.Shared
{
    public class Customer : INotifyDataErrorInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        // public string Origin 

        public bool HasErrors => GetErrors(string.Empty).Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(Name))
            {
                if (string.IsNullOrEmpty(Name))
                {
                    yield return $"A customer's name is mandatory";
                }

                else if (Name.Contains("Pizza"))
                {
                    yield return $"Name should not contain \"Pizza\"";
                }
            }

            else if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(Street))
            {
                if (string.IsNullOrEmpty(Street))
                {
                    yield return $"{propertyName} is mandatory";
                }
            }

            else if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(City))
            {
                if (string.IsNullOrEmpty(City))
                {
                    yield return $"{propertyName} is mandatory";
                }
            }
        }
    }
}