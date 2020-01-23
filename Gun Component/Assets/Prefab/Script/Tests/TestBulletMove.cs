using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BulletMoveTest
    {
        [UnityTest]
        public IEnumerator BulletMoveTest1()
        {
            Vector3 pos = new Vector3( 0,0,0 );
            float rotation = 0.0f;
            float scale = 1.0f;
            Vector3 desiredResult = new Vector3(0.0f, 1.0f, 0.0f);
            
            Vector3 result =  BulletMove.CalculateNewPos(pos, rotation, scale);
            if (result.x > -0.000001 && result.x < 0.000001)
            {
                result.x = 0;
            }
            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
        [UnityTest]
        public IEnumerator BulletMoveTest2()
        {
            Vector3 pos = new Vector3(0, 0, 0);
            float rotation = 180.0f;
            float scale = 1.0f;
            Vector3 desiredResult = new Vector3(0.0f, -1.0f, 0.0f);

            Vector3 result = BulletMove.CalculateNewPos(pos, rotation, scale);
            if (result.x > -0.000001 && result.x < 0.000001)
            {
                result.x = 0;
            }
            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
        [UnityTest]
        public IEnumerator BulletMoveTest3()
        {
            Vector3 pos = new Vector3(0, 0, 0);
            float rotation = 0.0f;
            float scale = 2.0f;
            Vector3 desiredResult = new Vector3(0.0f, 2.0f, 0.0f);

            Vector3 result = BulletMove.CalculateNewPos(pos, rotation, scale);
            if (result.x > -0.000001 && result.x < 0.000001)
            {
                result.x = 0;
            }
            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
        [UnityTest]
        public IEnumerator BulletMoveTest4()
        {
            Vector3 pos = new Vector3(1, 3, 0);
            float rotation = 0.0f;
            float scale = 1.0f;
            Vector3 desiredResult = new Vector3(1.0f, 4.0f, 0.0f);

            Vector3 result = BulletMove.CalculateNewPos(pos, rotation, scale);
            float temp = Mathf.Ceil(result.x);
            result.x -= temp;
            if (result.x > -0.000001 && result.x < 0.000001)
            {
                result.x = 0;
            }
            result.x += temp;
            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
    }
}
