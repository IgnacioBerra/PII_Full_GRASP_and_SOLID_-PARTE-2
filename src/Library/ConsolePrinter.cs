using System.Collections;
using System;


namespace Full_GRASP_And_SOLID.Library
{
        // La clase ConsolePrinter se encarga de imprimir la receta. Antes la función de imprimir estaba
        // dentro de la clase Recipe, de manera tal que no cumplía con el SRP. Ahora, al crear una nueva clase, 
        // cuya función es imprimir la receta, cada clase cumple una única responsabilidad. 
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe Object)
        {
            Console.WriteLine($"Receta de {Object.FinalProduct.Description}:");
            foreach (Step step in Object.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");

            }
            Console.WriteLine ($"El costo total de la receta es {Object.GetProductionCost()}"); 

        }
    }
}