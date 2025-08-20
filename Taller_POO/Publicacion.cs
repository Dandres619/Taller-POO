using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal abstract class Publicacion
    {
        private string _autor;
        private string _contenido;
        private DateTime _fechaPublicacion;

        public string Autor
        {
            get => _autor;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El autor no puede estar vacío.");
                _autor = value;
            }
        }

        public string Contenido
        {
            get => _contenido;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El contenido no puede estar vacío.");
                _contenido = value;
            }
        }

        public DateTime FechaPublicacion
        {
            get => _fechaPublicacion;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de publicación no existe.");
                _fechaPublicacion = value;
            }
        }

        public Publicacion(string autor, string contenido, DateTime fechaPublicacion)
        {
            Autor = autor;
            Contenido = contenido;
            FechaPublicacion = fechaPublicacion;
        }

        public abstract void MostrarPublicacion();
    }

    internal class PublicacionTexto : Publicacion
    {
        public PublicacionTexto(string autor, string contenido, DateTime fechaPublicacion)
            : base(autor, contenido, fechaPublicacion) { }

        public override void MostrarPublicacion()
        {
            Console.WriteLine($"(Texto) Autor: {Autor} - ({FechaPublicacion}): {Contenido}");
        }
    }

    internal class PublicacionImagen : Publicacion
    {
        private string _urlImagen;

        public string UrlImagen
        {
            get => _urlImagen;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La URL de la imagen no puede estar vacía.");
                _urlImagen = value;
            }
        }

        public PublicacionImagen(string autor, string contenido, DateTime fechaPublicacion, string urlImagen)
            : base(autor, contenido, fechaPublicacion)
        {
            UrlImagen = urlImagen;
        }

        public override void MostrarPublicacion()
        {
            Console.WriteLine($"(Imagen) Autor: {Autor} - ({FechaPublicacion}): {Contenido}\nUrl Imagen: {UrlImagen}");
        }
    }

    internal class PublicacionVideo : Publicacion
    {
        private string _urlVideo;
        private int _duracion;

        public string UrlVideo
        {
            get => _urlVideo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La URL del video no puede estar vacía.");
                _urlVideo = value;
            }
        }

        public int Duracion
        {
            get => _duracion;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La duración debe ser mayor a 0.");
                _duracion = value;
            }
        }

        public PublicacionVideo(string autor, string contenido, DateTime fechaPublicacion, string urlVideo, int duracion)
            : base(autor, contenido, fechaPublicacion)
        {
            UrlVideo = urlVideo;
            Duracion = duracion;
        }

        public override void MostrarPublicacion()
        {
            Console.WriteLine($"(Video) Autor: {Autor} - ({FechaPublicacion}): {Contenido}\nUrl Video: {UrlVideo} - ({Duracion} seg)");
        }
    }
}
