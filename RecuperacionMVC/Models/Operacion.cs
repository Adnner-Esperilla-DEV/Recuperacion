namespace RecuperacionMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Operacion")]
    public partial class Operacion
    {
        [Key]
        public int operacion_id { get; set; }

        public int numero1 { get; set; }

        public int numero2 { get; set; }

        public int tipooperacion_id { get; set; }

        public int resultado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha { get; set; }

        public TimeSpan hora { get; set; }

        [StringLength(10)]
        public string estado { get; set; }

        public virtual TipoOperacion TipoOperacion { get; set; }
        public List<Operacion> Listar()
        {
            var query = new List<Operacion>();

            try
            {
                using (var db = new Model1())
                {

                    query = db.Operacion.Include("TipoOperacion").Where(x => x.estado.Equals("A")).ToList();
                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return query;
        }
        public Operacion Obtener(int id)
        {
            var query = new Operacion();

            try
            {
                using (var db = new Model1())
                {


                    query = db.Operacion.Include("TipoOperacion")
                            .Where(x => x.operacion_id == id)
                            .SingleOrDefault();
                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return query;
        }
    }
}
