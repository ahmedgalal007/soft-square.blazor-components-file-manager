using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSBlazorFileManager.ClassLibrary.Components.TreeView;
public class TreeNodeDto
{
    public string Title { get; set; }
    public string Icon { get; set; }

    public List<TreeNodeItem> Items { get; set; } = new List<TreeNodeItem>();
    public List<TreeNodeDto> Nodes { get; set; } = new List<TreeNodeDto>();

}
