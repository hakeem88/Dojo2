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
    public class ItemVM : ViewModelBase
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

        public String ValueType {
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

        public Type ItemType
        {
            get
            {
                if (test is ISensor) return typeof(ISensor);
                else if (test is IActuator) return typeof(IActuator);
                else throw new NotImplementedException();
            }
        }


        public String Mode
        {
            get
            {
                if (test is ISensor)
                    return (test as BaseSensor).SensorMode.ToString();
                if (test is IActuator)
                    return (test as BaseActuator).ActuatorMode.ToString();
                else return null;
            }
            set
            {
                if (test is ISensor)
                    (test as BaseSensor).SensorMode = (SensorModeType)Enum.Parse(typeof(SensorModeType), value, false);
                if (test is IActuator)
                    (test as BaseActuator).ActuatorMode = (ModeType)Enum.Parse(typeof(ModeType), value, false);

                RaisePropertyChanged();
            }
        }

        public object Value
        {
            get {
                if (test is ISensor)
                    return (test as BaseSensor).SensorValue;
                else if (test is IActuator)
                    return (test as BaseActuator).ActuatorValue;
                else
                    throw new NotImplementedException();
            }
            set {
                if (test is ISensor) (test as BaseSensor).SensorValue = value;
                else if (test is IActuator) (test as BaseActuator).ActuatorValue = value;
                else throw new NotImplementedException();
                RaisePropertyChanged();
            }
        }

        public ItemVM(ISensor sensor)
        {
            test = sensor as ItemBase;
        }

        public ItemVM(IActuator actuator)
        {
            test = actuator as ItemBase;
        }


    }
}
