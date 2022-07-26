namespace RegistroTickets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Ticket")]
    public partial class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Ticket { get; set; }

        [Required]
        [StringLength(50)]
        public string persona_Sol { get; set; }

        [Required]
        [StringLength(30)]
        public string asunto { get; set; }

        [Required]
        [StringLength(100)]
        public string descrip_incidencia { get; set; }

        public DateTime fecha_Ingreso { get; set; }
        //----Metodos----
        public List<Ticket> listarTickets()
        {
            var tickets= new List<Ticket>();
            String cadena = "Select * from Ticket";
            try
            {
                using (var contenedor = new Model1())
                {
                    tickets = contenedor.Database.SqlQuery<Ticket>(cadena).ToList();

                }
            }
            catch (Exception)
            {

                //throw;
            }
            return tickets;
        }
        public Boolean InsertarTicket(String personaSoli,String asunto,String descripInci,DateTime fecha)
        {
            bool estado = false;
            String cadena="'"+personaSoli+"',";
            cadena=cadena+"'"+asunto+"',";
            cadena = cadena + "'" + descripInci + "',";
            cadena = cadena + "'" + fecha + "'";

            try
            {
                using (var cnx=new Model1())
                {
                    int r = cnx.Database.ExecuteSqlCommand("Insert into Ticket values (" + cadena + ")");
                    if (r == 1)
                    {
                        estado = true;
                    } 
                }
            }
            catch (Exception)
            {
                estado=false;
                //throw;
            }
            return estado;
        }
    }
}
