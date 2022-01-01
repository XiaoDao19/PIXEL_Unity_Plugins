using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PIXEl.Plugin.TimeMotionControl
{
    public static class TimeMotionControlFunctions
    {
        public static float slowdownFactor = 0f;
        public static float accelerateFactor = 0f;

        public static void Time_SlowDown()
        {
            Time.timeScale = slowdownFactor;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }

        public static void Time_Accelerate()
        {
            Time.timeScale = 1f * accelerateFactor;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }

        public static void Time_Normal()
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }

        public static void Time_Stop()
        {
            Time.timeScale = 0f;
        }
    }
}