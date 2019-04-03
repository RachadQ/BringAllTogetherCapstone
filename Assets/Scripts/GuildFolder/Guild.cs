using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Guild
{
    internal struct MemberInfo
    {
        public string Name;
        public GuildRank rank;
        public ushort level;
        public int totalDonation;
    }

    public GuildAttr _info = new GuildAttr();
    private IList<MemberInfo> _members;

    public  uint Id { get { return _info.Id; } set { _info.Id = value; } }
    public string Name { get { return _info.Name; } set { _info.Name = value; } }
    public string Announce { get { return _info.Announce; } set { _info.Announce = value; } }
    public string AnnounceDate { get { return _info.AnnounceDate; } set { _info.AnnounceDate = value; } }
    public uint GL_Id { get { return _info.GL_Id; } set { _info.GL_Id = value; } }
    public string GL_Name { get { return _info.GL_Name; } set { _info.GL_Name = value; } }
    public long Money { get { return _info.Money; } set { _info.Money = value; } }
    public int Amount { get { return _info.amount; } set { _info.amount = value; } }

    public uint GuildsEnemy0 { get { return _info.GuildsEnemy0; } set { _info.GuildsEnemy0 = value; } }
    public uint GuildsEnemy1 { get; set; }


    public uint GuildsAlly0 { get { return _info.GuildsAlly0; } set { _info.GuildsAlly0 = value; } }
    public uint GuildsAlly1 { get { return _info.GuildsAlly1; } set { GuildsAlly1 = value; } }



    // Start is called before the first frame update
    void Start()
    {
        _info = new GuildAttr();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
