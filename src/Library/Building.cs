//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Building
    {
        public ArrayList tasks = new ArrayList();

        public Building(string name)
        {
            this.Description = name;
        }

        public string Description { get; set; }

        public void AddTask(Task task)
        {
            this.tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }

        //Patrón Expert 
        public double GetProductionCost()
        {
            double materialCost = 0;
            double toolsCost = 0;
            foreach (Task task in this.tasks)
            {
                materialCost += task.Material.UnitCost * task.Quantity;
                toolsCost += task.Equipment.HourlyCost * task.Time;
            }
            double totalCost = materialCost + toolsCost;
            return totalCost;
        
        }

        

        public string PrintBuilding()
        {
            string printBuilding = "";
            printBuilding += $"Edificio {this.Description}: \n";
            foreach (Task task in this.tasks)
            {
                printBuilding += $"{task.Quantity} de '{task.Material.Description}' " +
                    $"usando '{task.Equipment.Description}' durante {task.Time} \n";
            }
            printBuilding += $"Costo total de la construcción: {this.GetProductionCost()} \n";
            return printBuilding;
        }
    }
}