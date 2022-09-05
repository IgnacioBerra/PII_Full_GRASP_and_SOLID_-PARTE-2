//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }
        public double InsumosCost {get;set;} = 0;
        public double EquipmentCost {get;set;}
        public double TotalCost{get;set;}
        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // Cumpliendo con el principio Expert, debemos asignarle la responsabilidad de conocer el costo total a la clase que conozca la información necesaria.
        // La clase Step conoce la información de product y equipment, pero como la clase Step colabora con Recipe, consideré que
        // la mejor opción era en esta clase. Para esta primer entrega, cree la funcion GetProductionCost(), e imprime el total en la función PrintRecipe().
        public double GetProductionCost()
        {
            foreach (Step Object in steps)
            {
              InsumosCost = InsumosCost + (Object.Input.UnitCost * Object.Quantity) ;
            }

            foreach (Step Object in steps)
            {
            EquipmentCost = EquipmentCost + (Object.Equipment.HourlyCost * Object.Time); 
            }

            TotalCost = InsumosCost + EquipmentCost;

            return TotalCost;
        }
        
    }
}
