using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEncounter { }
public class invalidEncounter: IEncounter { }
public class LowLevelDesert : IEncounter { }
public class MidLevelDesert : IEncounter { }
public class HighLevelDesert : IEncounter { }
public class LowLevelForest : IEncounter { }
public class MidLevelForest : IEncounter { }
public class HighLevelForest : IEncounter { }
public class LowLevelDungeon : IEncounter { }
public class MidLevelDungeon : IEncounter { }
public class HighLevelDungeon : IEncounter { }
public class LowLevelUrban : IEncounter { }
public class MidLevelUrban : IEncounter { }
public class HighLevelUrban : IEncounter { }