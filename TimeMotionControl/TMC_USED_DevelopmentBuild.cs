using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PIXEl.Plugin.TimeMotionControl
{
    public class TMC_USED_DevelopmentBuild : MonoBehaviour
    {
#if DEVELOPMENT_BUILD
        private void Start()
        {
            Debug.Log("Time.scale: " + Time.timeScale);
            Debug.Log("Time.fixedDeltaTime: " + Time.fixedDeltaTime);
        }

        private void OnGUI()
        {
            GUILayout.BeginArea(new Rect(10, 5, 130, 20));
            if (GUILayout.Button("Time Normal", GUILayout.Width(130)))
            {
                TimeMotionControlFunctions.Time_Normal();
            }
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(150, 5, 130, 20));
            if (GUILayout.Button("Time Stop", GUILayout.Width(130)))
            {
                TimeMotionControlFunctions.Time_Stop();
            }
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(10, 45, 130, 20));
            GUILayout.Label("减速系数");
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(70, 45, 130, 20));
            TimeMotionControlFunctions.slowdownFactor = GUILayout.HorizontalSlider(TimeMotionControlFunctions.slowdownFactor, 0f, 0.1f, GUILayout.Width(130));
            GUILayout.EndArea();
            GUILayout.BeginArea(new Rect(10, 65, 130, 20));
            if (GUILayout.Button("Time Slow", GUILayout.Width(130)))
            {
                TimeMotionControlFunctions.Time_SlowDown();
            }
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(10, 105, 130, 20));
            GUILayout.Label("加速系数");
            GUILayout.EndArea();
            GUILayout.BeginArea(new Rect(70, 105, 130, 20));
            TimeMotionControlFunctions.accelerateFactor = GUILayout.HorizontalSlider(TimeMotionControlFunctions.accelerateFactor, 0f, 10f, GUILayout.Width(130));
            GUILayout.EndArea();
            GUILayout.BeginArea(new Rect(10, 125, 130, 20));
            if (GUILayout.Button("Time Accelerate", GUILayout.Width(130)))
            {
                TimeMotionControlFunctions.Time_Accelerate();
            }
            GUILayout.EndArea();
        }
        #endif
    }
    }