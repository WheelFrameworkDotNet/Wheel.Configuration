using System.Configuration;
using Wheel.Data.Json;

namespace Wheel.Configuration.Section
{
    /// <summary>
    /// Representa una propiedad de configuración.
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
    public class PropiedadConfiguracion : ConfigurationElement
    {
        /// <summary>
        /// Obtiene o establece el nombre identificador del archivo. Puede no corresponder al nombre del archivo físico.
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
        [ConfigurationProperty("Name", IsRequired = true, IsKey = true)]
        public string Nombre
        {
            get
            {
                return this["Name"] as string;
            }

            set
            {
                this["Name"] = value;
            }
        }

        /// <summary>
        /// Obtiene o establece la ruta del archivo.
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
        [ConfigurationProperty("Value", IsRequired = true)]
        private string _Valor
        {
            get
            {
                return this["Value"] as string;
            }

            set
            {
                this["Value"] = value;
            }
        }

        /// <summary>
        /// Obtiene o establece el valor de la propiedad de configuración.
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
        public object Valor 
        {
            get
            {
                return _Valor.ToObject(false);
            }

            set
            {
                _Valor = value.ToJson();
            }
        }
    }
}
