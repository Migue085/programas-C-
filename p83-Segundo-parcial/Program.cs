/*Leer n calificaciones flotantes en un arreglo (deberá validar que la calificación esté entre 10 y 100) 
• Mostrar las calificaciones 
• Calcular promedio y mostrar las calificaciones mayores al promedio 
• Muestra el complemento a 100 del arreglo (cuanto le falta a cada número para llegar a 100) 
• Contar calificación (pedir una calificación y contar cuantas veces aparece) */

Console.Clear();
Console.Write("Ingrese el número de calificaciones: ");
int n = int.Parse(Console.ReadLine());
float[] calificaciones = new float[n];

for (int i = 0; i < n; i++)
    {
        Console.Write($"Ingrese la calificación {i+1}: ");
        float calificacion = float.Parse(Console.ReadLine());
            while (calificacion < 10 || calificacion > 100)
            {
                Console.Write("Calificación inválida. Ingrese otra calificación: ");
                calificacion = float.Parse(Console.ReadLine());
            }
            calificaciones[i] = calificacion;
        }
        
        Console.WriteLine("Las calificaciones ingresadas son:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(calificaciones[i]);
        }
        float suma = 0;
        for (int i = 0; i < n; i++)
        {
            suma += calificaciones[i];
        }
        float promedio = suma / n;
        Console.WriteLine($"El promedio de las calificaciones es {promedio}");
        Console.WriteLine("Las calificaciones mayores al promedio son:");
        for (int i = 0; i < n; i++)
        {
            if (calificaciones[i] > promedio)
            {
                Console.WriteLine(calificaciones[i]);
            }
        }
        Console.WriteLine("El complemento a 100 de las calificaciones es:");
        for (int i = 0; i < n; i++)
        {
            float complemento = 100 - calificaciones[i];
            Console.WriteLine(complemento);
        }
        Console.WriteLine("Ingrese una calificación para buscar: ");
        float buscado = float.Parse(Console.ReadLine());
        int contador = 0;
        for (int i = 0; i < n; i++)
        {
            if (calificaciones[i] == buscado)
            {
                contador++;
            }
        }
        Console.WriteLine($"La calificación {buscado} aparece {contador} veces");
    