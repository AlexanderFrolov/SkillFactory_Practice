using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Базовый абстрактный класс
    /// </summary>
    abstract class BaseClass { }

    /// <summary>
    /// Конкретная реализация А
    /// </summary>
    class ConcreteClassA : BaseClass { }

    /// <summary>
    /// Конкретная реализация B
    /// </summary>
    class ConcreteClassB : BaseClass { }

    /// <summary>
    /// Абстрактный класс от которого наследуются конкретные реализации
    /// </summary>
    abstract class Creator
    {
        /// Фабричный метод который будет переопределен в классах наследниках
        public abstract BaseClass FactoryMethod();
    }

    /// <summary>
    /// Конкретная реализация А
    /// </summary>
    class ConcreteCreatorA : Creator
    {
        public override BaseClass FactoryMethod()
        {
            /// Переопределенный фабричный метод здесь возвращает конкретную реализацию
            return new ConcreteClassA();
        }
    }

    /// <summary>
    /// Конкретная реализация B
    /// </summary>
    class ConcreteCreatorB : Creator
    {
        public override BaseClass FactoryMethod()
        {
            /// Переопределенный фабричный метод здесь возвращает конкретную реализацию
            return new ConcreteClassB();
        }
    }
}
