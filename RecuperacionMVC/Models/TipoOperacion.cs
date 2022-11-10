namespace RecuperacionMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("TipoOperacion")]
    public partial class TipoOperacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoOperacion()
        {
            Operacion = new HashSet<Operacion>();
        }

        [Key]
        public int tipooperacion_id { get; set; }

        [Required]
        [StringLength(250)]
        public string nombre { get; set; }

        [StringLength(10)]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacion> Operacion { get; set; }

        public List<TipoOperacion> Listar()
        {
            var query = new List<TipoOperacion>();

            try
            {
                using (var db = new Model1())
                {

                    query = db.TipoOperacion.Where(x => x.estado.Equals("A")).ToList();
                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return query;
        }
        public TipoOperacion Obtener(int id)
        {
            var query = new TipoOperacion();

            try
            {
                using (var db = new Model1())
                {


                    query = db.TipoOperacion
                            .Where(x => x.tipooperacion_id == id)
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
