﻿namespace NahalyBenavidesExamenWeb.Entities
{
    public class Pareja
    {
        public int ParejaId { get; set; }

        public string Nombre { get; set; }

        public Estudiante Estudiante { get; set; }
    }

}
}
