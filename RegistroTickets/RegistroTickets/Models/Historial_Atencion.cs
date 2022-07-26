namespace RegistroTickets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Historial_Atencion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Historial { get; set; }

        public DateTime fecha_Atencion { get; set; }

        [Required]
        [StringLength(30)]
        public string coment_realizado { get; set; }
    }
}
