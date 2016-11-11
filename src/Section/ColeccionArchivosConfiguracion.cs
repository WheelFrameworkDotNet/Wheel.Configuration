using System.Configuration;

namespace Wheel.Configuration.Section
{
    /// <summary>
    /// Colección de elementos de configuración que contiene una lista de Archivos de configuración externos.
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
    public class ColeccionArchivosConfiguracion : ConfigurationElementCollection
    {
        /// <summary>
        /// Obtiene o establece un archivo de configuración externo según el indice.
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
        /// <param name="index">Índice o posición del elemento en la colección.</param>
        /// <returns></returns>
        public ArchivoConfiguracion this[int index]
        {
            get { return (ArchivoConfiguracion)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        /// <summary>
        /// Agrega un elemento de configuración a la colección actual.
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
        /// <param name="archivoConfiguracion">Archivo de configuración a añadir.</param>
        public void Add(ArchivoConfiguracion archivoConfiguracion)
        {
            BaseAdd(archivoConfiguracion);
        }

        /// <summary>
        /// Vacia la colección de elementos.
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
        public void Clear()
        {
            BaseClear();
        }

        /// <summary>
        /// Crea un nuevo elemento de configuración.
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
        protected override ConfigurationElement CreateNewElement()
        {
            return new ArchivoConfiguracion();
        }

        /// <summary>
        /// Obtiene la clave de un elemento de configuración.
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
        /// <param name="archivoConfiguracion">Archivo de configuración.</param>
        /// <returns></returns>
        protected override object GetElementKey(ConfigurationElement archivoConfiguracion)
        {
            return ((ArchivoConfiguracion)archivoConfiguracion).Nombre;
        }

        /// <summary>
        /// Elimina un elemento de la colección.
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
        /// <param name="archivoConfiguracion">Archivo de configuración a eliminar.</param>
        public void Remove(ArchivoConfiguracion archivoConfiguracion)
        {
            BaseRemove(archivoConfiguracion.Nombre);
        }

        /// <summary>
        /// Elimina el elemento ubicado en el índice especificado.
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
        /// <param name="index">Índice del elemento a eliminar.</param>
        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        /// <summary>
        /// Elimina un elemento según su nombre.
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
        /// <param name="name">Nombre del elemento.</param>
        public void Remove(string name)
        {
            BaseRemove(name);
        }
    }
}
