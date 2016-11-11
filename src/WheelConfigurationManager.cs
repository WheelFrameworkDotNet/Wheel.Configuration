using System;
using System.Collections.Generic;
using Wheel.Configuration.Exceptions;
using Wheel.Configuration.Section;

namespace Wheel.Configuration
{
    /// <summary>
    /// Clase estática que representa el administrador de las configuraciones.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <h2 class="groupheader">Registro de versiones</h2>
    ///         <ul>
    ///             <li>1.0.0</li>
    ///             <table>
    ///                 <tr style="font-weight: bold;">
    ///                     <td>Autor</td>
    ///                     <td>Fecha</td>
    ///                     <td>Descripción</td>
    ///                 </tr>
    ///                 <tr>
    ///                     <td>Marcos Abraham Hernández Bravo.</td>
    ///                     <td>10/11/2016</td>
    ///                     <td>Versión Inicial.</td>
    ///                 </tr>
    ///             </table>
    ///         </ul>
    ///     </para>
    /// </remarks>
    public static class WheelConfigurationManager
    {
        /// <summary>
        /// Obtiene las propiedades de un grupo de configuración.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>10/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="grupo">Nombre del grupo.</param>
        /// <returns></returns>
        public static IList<PropiedadConfiguracion> ObtenerPropiedades(string grupo)
        {
            IList<PropiedadConfiguracion> retorno = new List<PropiedadConfiguracion>();

            object seccion = System.Configuration.ConfigurationManager.GetSection("FrameworkConfigSection/FrameworkConfig");

            FrameworkConfigSection config = seccion as FrameworkConfigSection;

            if (config == null)
            {
                throw new WheelConfigurationException("¡No está declarada la sección de configuración en el archivo!");
            }

            if (!(seccion is FrameworkConfigSection))
            {
                throw new WheelConfigurationException("¡El tipo de la sección FrameworkConfigSection/FrameworkConfig no es Wheel.Configuration.Section.FrameworkConfigSection!");
            }

            if (string.IsNullOrEmpty(grupo))
            {
                throw new WheelConfigurationException("¡El grupo no puede ser nulo o vacio!");
            }

            foreach (ColeccionPropiedadesConfiguracion xGrupo in config.ConfigProperties)
            {
                if (xGrupo.Nombre.Equals(grupo, StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (PropiedadConfiguracion propiedad in xGrupo)
                    {
                        retorno.Add(propiedad);
                    }
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Obtiene los grupos de configuración y sus correspondientes propiedades definidas.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>10/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <returns></returns>
        public static IList<ColeccionPropiedadesConfiguracion> ObtenerGrupos()
        {
            IList<ColeccionPropiedadesConfiguracion> retorno = new List<ColeccionPropiedadesConfiguracion>();

            object seccion = System.Configuration.ConfigurationManager.GetSection("FrameworkConfigSection/FrameworkConfig");

            FrameworkConfigSection config = seccion as FrameworkConfigSection;

            if (config == null)
            {
                throw new WheelConfigurationException("¡No está declarada la sección de configuración en el archivo!");
            }

            if (!(seccion is FrameworkConfigSection))
            {
                throw new WheelConfigurationException("¡El tipo de la sección FrameworkConfigSection/FrameworkConfig no es Wheel.Configuration.Section.FrameworkConfigSection!");
            }

            foreach (ColeccionPropiedadesConfiguracion grupo in config.ConfigProperties)
            {
                retorno.Add(grupo);
            }

            return retorno;
        }

        /// <summary>
        /// Obtiene una propiedad según su nombre y grupo.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>10/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="grupo">Nombre del grupo.</param>
        /// <param name="nombre">Nombre de la propiedad.</param>
        /// <returns></returns>
        public static PropiedadConfiguracion ObtenerPropiedad(string grupo, string nombre)
        {
            object seccion = System.Configuration.ConfigurationManager.GetSection("FrameworkConfigSection/FrameworkConfig");

            FrameworkConfigSection config = seccion as FrameworkConfigSection;

            if (config == null)
            {
                throw new WheelConfigurationException("¡No está declarada la sección de configuración en el archivo!");
            }

            if (!(seccion is FrameworkConfigSection))
            {
                throw new WheelConfigurationException("¡El tipo de la sección FrameworkConfigSection/FrameworkConfig no es Wheel.Configuration.Section.FrameworkConfigSection!");
            }

            if (string.IsNullOrEmpty(grupo))
            {
                throw new WheelConfigurationException("¡El grupo no puede ser nulo o vacio!");
            }

            if (string.IsNullOrEmpty(nombre))
            {
                throw new WheelConfigurationException("¡El nombre de la propiedad no puede ser nulo o vacio!");
            }

            bool existeGrupo = false;

            foreach (ColeccionPropiedadesConfiguracion xGrupo in config.ConfigProperties)
            {
                if (xGrupo.Nombre.Equals(grupo, StringComparison.InvariantCultureIgnoreCase))
                {
                    existeGrupo = true;
                    foreach (PropiedadConfiguracion propiedad in xGrupo)
                    {
                        if (propiedad.Nombre.Equals(nombre, StringComparison.InvariantCultureIgnoreCase))
                        {
                            return propiedad;
                        }
                    }
                    break;
                }
            }
            if (!existeGrupo)
            {
                throw new WheelConfigurationException(string.Format("¡No está declarado el grupo de propiedades {0}!", grupo));
            }
            else
            {
                throw new WheelConfigurationException(string.Format("¡No está declarado la propiedad {0} del grupo de propiedades {1}!", nombre, grupo));
            }
        }

        /// <summary>
        /// Obtiene el valor de una propiedad según su nombre y grupo.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>10/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="grupo">Nombre del grupo.</param>
        /// <param name="nombre">Nombre de la propiedad.</param>
        /// <returns></returns>
        public static object ObtenerValorPropiedad(string grupo, string nombre)
        {
            return ObtenerPropiedad(grupo, nombre).Valor;
        }

        /// <summary>
        /// Obtiene el valor de la propiedad según su nombre y grupo casteado al tipo especificado.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>10/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <typeparam name="T">Tipo del valor de la propiedad.</typeparam>
        /// <param name="grupo">Nombre del grupo.</param>
        /// <param name="nombre">Nombre de la propiedad.</param>
        /// <returns></returns>
        public static T ObtenerValorPropiedad<T>(string grupo, string nombre)
        {
            return (T)ObtenerPropiedad(grupo, nombre).Valor;
        }

        /// <summary>
        /// Obtiene un archivo de configuración según su nombre.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>10/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="nombre">Nombre del archivo de configuración.</param>
        /// <returns></returns>
        public static ArchivoConfiguracion ObtenerArchivoConfiguracion(string nombre)
        {
            object seccion = System.Configuration.ConfigurationManager.GetSection("FrameworkConfigSection/FrameworkConfig");

            FrameworkConfigSection config = seccion as FrameworkConfigSection;

            if (config == null)
            {
                throw new WheelConfigurationException("¡No está declarada la sección de configuración en el archivo!");
            }

            if (!(seccion is FrameworkConfigSection))
            {
                throw new WheelConfigurationException("¡El tipo de la sección FrameworkConfigSection/FrameworkConfig no es Wheel.Configuration.Section.FrameworkConfigSection!");
            }

            if (string.IsNullOrEmpty(nombre))
            {
                throw new WheelConfigurationException("¡El nombre no puede ser nulo o vacio!");
            }

            foreach (ArchivoConfiguracion archivoConfiguracion in config.ConfigFiles)
            {
                if (archivoConfiguracion.Nombre.Equals(nombre, StringComparison.InvariantCultureIgnoreCase))
                {
                    return archivoConfiguracion;
                }
            }

            throw new WheelConfigurationException(string.Format("¡No está declarado el archivo de configuración {0}!", nombre));
        }

        /// <summary>
        /// Obtiene la ruta del archivo de configuración señalado.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>10/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="nombre">Nombre del archivo.</param>
        /// <returns></returns>
        public static string ObtenerRutaArchivoConfiguracion(string nombre)
        {
            return ObtenerArchivoConfiguracion(nombre).Ruta;
        }
    }
}
