using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class tests
{

    // A Test behaves as an ordinary method
    [Test]
    public void testsSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator testsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }


    [UnityTest]
    public IEnumerator IfPatricleSpawned()
    {
        bool positive = false;

        GameObject bullet = MonoBehaviour.Instantiate(Resources.Load<GameObject>("prefabs/BulletCasting"));

        yield return new WaitForSeconds(2.0f);
        if (bullet.transform.position.y < 0)
        {
         positive = true;
        }
        
        Assert.IsTrue(positive);
    }
}
