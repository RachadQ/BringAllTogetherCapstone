using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuildAttr 
{
    public virtual uint Id { get; set; }
    public virtual string Name { get; set; }
    public virtual string Announce { get; set; }
    public virtual string AnnounceDate { get; set; }
    public virtual uint GL_Id { get; set; }
    public virtual string GL_Name { get; set; }
    public virtual long Money { get; set; }
    public virtual int amount { get; set; }

    public virtual uint GuildsEnemy0 { get; set; }
    public virtual uint GuildsEnemy1 { get; set; }
   

    public virtual uint GuildsAlly0 { get; set; }
    public virtual uint GuildsAlly1 { get; set; }
   
} 
