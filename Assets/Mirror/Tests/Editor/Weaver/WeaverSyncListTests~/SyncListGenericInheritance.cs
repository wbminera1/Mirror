using UnityEngine;
using Mirror;

namespace MirrorTest
{
    class SyncListGenericInheritance : NetworkBehaviour
    {
        readonly SomeListInt superSyncListString = new SomeListInt();
    }

    public abstract class SomeList<T> : SyncList<T> { }
    
    public class SomeListInt : SyncList<int> { }
}
