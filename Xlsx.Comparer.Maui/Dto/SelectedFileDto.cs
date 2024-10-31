using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xlsx.Comparer.Maui.Dto
{
    /// <summary>
    /// Define la estructura de un archivo seleccionado
    /// </summary>
    public record SelectedFileDto(bool IsSelected, string FullPath)
    {

    }
}
