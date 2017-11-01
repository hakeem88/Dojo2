using Shared.BaseModels;
using Shared.Interfaces;
using Shared.Models;
using System;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dojo2.ViewModels
{
    public class ItemVM
    {
        public ItemBase test;


        public int Id
        {
            get { return test.Id; }
        }

        public string Description
        {
            get { return test.Description; }
            set { test.Description = value; RaisePropertyChanged(); }
        }

        public string Name
        {
            get { return test.Name; }
            set { test.Name = value; RaisePropertyChanged(); }
        }

        public string Room
        {
            get { return test.Room; }
            set { test.Room = value; RaisePropertyChanged(); }
        }

        public int PosX
        {
            get { return test.PosX; }
            set { test.PosX = value; RaisePropertyChanged(); }
        }

        public int PosY
        {
            get { return test.PosY; }
            set { test.PosY = value; RaisePropertyChanged(); }
        }

        public string ValueType
        {
            get
            {
                if (test is ISensor)
                    return (test as BaseSensor).SensorValueType.Name;
                else if (test is IActuator)
                    return (test as BaseActuator).ActuatorValueType.Name;
                else
                    throw new NotImplementedException();
            }

        }
    }
}
