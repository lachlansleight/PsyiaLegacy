using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StarLabSettings_Debug))]
public class StarLabSettingsDebug_Inspector : Editor {

	public override void OnInspectorGUI() {
		EditorGUILayout.LabelField("Visual Settings", EditorStyles.boldLabel);
		EditorGUILayout.IntField("Particle Form", PsyiaSettings.ParticleForm);
		EditorGUILayout.IntField("Color Mode", PsyiaSettings.ColorMode);
		EditorGUILayout.FloatField("Line Length", PsyiaSettings.LineLength);
		EditorGUILayout.FloatField("Ship Size", PsyiaSettings.ShipSize);
		EditorGUILayout.Space();

		//Control Settings
		EditorGUILayout.LabelField("Control Settings", EditorStyles.boldLabel);
		EditorGUILayout.FloatField("Controller Force", PsyiaSettings.ControllerForce);
		EditorGUILayout.IntField("Left Touchpad Function", PsyiaSettings.LeftTouchpadFunction);
		EditorGUILayout.IntField("Right Touchpad Function", PsyiaSettings.RightTouchpadFunction);
		EditorGUILayout.FloatField("Controller Distance", PsyiaSettings.ControllerDistance);
		EditorGUILayout.Toggle("Controller Models", PsyiaSettings.ControllerModels);
		EditorGUILayout.Space();

		//Audio Settings
		EditorGUILayout.LabelField("Audio Settings", EditorStyles.boldLabel);
		EditorGUILayout.FloatField("Visualization Strength (Physics)", PsyiaSettings.VisualizationStrengthPhysics);
		EditorGUILayout.FloatField("Visualization Strength (Graphics)", PsyiaSettings.VisualizationStrengthGraphics);
		EditorGUILayout.IntField("Song Playing", PsyiaSettings.SongPlaying);
		EditorGUILayout.Toggle("Loop", PsyiaSettings.Loop);
		EditorGUILayout.FloatField("Volume", PsyiaSettings.Volume);
		EditorGUILayout.Toggle("Music Slows With Time", PsyiaSettings.MusicSlowsWithTime);
		EditorGUILayout.Space();

		//Physics Settings
		EditorGUILayout.LabelField("Physics Settings", EditorStyles.boldLabel);
		EditorGUILayout.FloatField("Particle Mass", PsyiaSettings.ParticleMass);
		EditorGUILayout.FloatField("Velocity Dampening", PsyiaSettings.VelocityDampening);
		EditorGUILayout.FloatField("Vortex Strength", PsyiaSettings.VortexStrength);
		EditorGUILayout.Toggle("Room Collision", PsyiaSettings.RoomCollision);
		EditorGUILayout.Toggle("Jelly Mode", PsyiaSettings.JellyMode);
		EditorGUILayout.Space();

		//System Settings
		EditorGUILayout.LabelField("System Settings", EditorStyles.boldLabel);
		EditorGUILayout.IntField("Particle Count", PsyiaSettings.ParticleCount);
		EditorGUILayout.IntField("Antialiasing", PsyiaSettings.Antialiasing);
		EditorGUILayout.Toggle("Bloom", PsyiaSettings.Bloom);
		EditorGUILayout.Space();

		//MeditationSettings
		EditorGUILayout.LabelField("Meditation Settings", EditorStyles.boldLabel);
		EditorGUILayout.IntField("Meditation Posture", PsyiaSettings.MeditationPosture);
		EditorGUILayout.Space();

		//App Settings
		EditorGUILayout.LabelField("App Settings", EditorStyles.boldLabel);
		EditorGUILayout.Toggle("First Time", PsyiaSettings.FirstTime);
	}
}
