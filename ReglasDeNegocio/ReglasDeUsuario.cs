using System.ComponentModel.DataAnnotations;
using Laboratorio8.Models;

namespace Laboratorio8.ReglasDeNegocio
{
    public static class ReglasDeUsuario
    {
        public static bool EsValido(Usuario usuario)
        {
            if (usuario == null) return false;

            if (usuario.IdUsuario == null)
                return false;

            if (string.IsNullOrEmpty(usuario.Nombre) || usuario.Nombre.Length < 3 || usuario.Nombre.Length > 100)
                return false;

            if(string.IsNullOrEmpty(usuario.Correo) || !new EmailAddressAttribute().IsValid(usuario.Correo))
                return false;

            if (string.IsNullOrEmpty(usuario.Contraseña) || usuario.Contraseña.Length < 8 || !ValidarContraseña(usuario.Contraseña))
                return false;

            if(usuario.FechaRegistro == default)
                return false;

            return true;
        }

        private static bool ValidarContraseña(string contraseña)
        {
            var hasUpperChar = contraseña.Any(c => Char.IsUpper(c));
            var hasDigit = contraseña.Any(c => Char.IsDigit(c));
            var hasSpecialChar = contraseña.Any(c => "!@#$%^&*()".Contains(c));
            return hasUpperChar && hasDigit && hasSpecialChar;
        }
    }
}
