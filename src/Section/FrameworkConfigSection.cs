using System.Configuration;

namespace Wheel.Configuration.Section
{
    /// <summary>
    /// Representa la sección de configuración de WheelFramework.
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
    public class FrameworkConfigSection : ConfigurationSection
    {
        /// <summary>
        /// Obtiene la colección de archivos de configuración especificados.
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
        [ConfigurationProperty("ConfigFiles", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ColeccionArchivosConfiguracion),
            AddItemName = "File",
            ClearItemsName = "Clear",
            RemoveItemName = "Delete")]
        public ColeccionArchivosConfiguracion ConfigFiles
        {
            get
            {
                return (ColeccionArchivosConfiguracion)base["ConfigFiles"];
            }
        }

        /// <summary>
        /// Obtiene los grupos de propiedades de configuración especificados.
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
        [ConfigurationProperty("ConfigProperties", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(GrupoPropiedadesConfiguracion),
            AddItemName = "PropertiesGroup",
            ClearItemsName = "Clear",
            RemoveItemName = "Delete")]
        public GrupoPropiedadesConfiguracion ConfigProperties
        {
            get
            {
                return (GrupoPropiedadesConfiguracion)base["ConfigProperties"];
            }
        }

    }
}
