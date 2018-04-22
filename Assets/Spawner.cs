using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	private float _start_pos = 0;
	private float _monster_spawn_height = 15;
	private float _warning_height = -20;

	private bool _wave_1_spawned = false;
	private bool _wave_2_spawned = false;
	private bool _wave_3_spawned = false;
	private bool _wave_4_spawned = false;
	private bool _wave_5_spawned = false;
	private bool _wave_6_spawned = false;

	public float WAVE_1_DIST = 20;
	public float WAVE_2_DIST = 40;
	public float WAVE_3_DIST = 60;
	public float WAVE_4_DIST = 80;
	public float WAVE_5_DIST = 100;
	public float WAVE_6_DIST = 120;

	public GameObject MONSTER_TYPE_1;
	public GameObject MONSTER_TYPE_2;

	public GameObject WARNING_MESSAGE;

	// Use this for initialization
	void Start () {
		_start_pos = transform.position.x;
	}
		
	private void _spawnWave(int waveNumber, float distance){
		Instantiate (WARNING_MESSAGE, new Vector3 (distance - 6f, _warning_height, 0), Quaternion.identity);
		if (waveNumber == 1) {
			Instantiate (MONSTER_TYPE_1, new Vector3 (distance + 4f, _monster_spawn_height, 0), Quaternion.identity);
		}
		else if (waveNumber == 2) {
			Instantiate (MONSTER_TYPE_2, new Vector3 (distance + 4f, _monster_spawn_height, 0), Quaternion.identity);
		}
		else if (waveNumber == 3) {
			Instantiate (MONSTER_TYPE_1, new Vector3 (distance + 4f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate (MONSTER_TYPE_2, new Vector3 (distance + 6f, _monster_spawn_height, 0), Quaternion.identity);
		}
		else if (waveNumber == 4) {
			Instantiate (MONSTER_TYPE_1, new Vector3 (distance + 4f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate (MONSTER_TYPE_2, new Vector3 (distance + 6f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate (MONSTER_TYPE_1, new Vector3 (distance + 8f, _monster_spawn_height, 0), Quaternion.identity);
		} 
		else if (waveNumber == 5) {
			Instantiate(MONSTER_TYPE_1, new Vector3 (distance + 4f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate(MONSTER_TYPE_2, new Vector3 (distance + 6f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate(MONSTER_TYPE_1, new Vector3 (distance + 8f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate(MONSTER_TYPE_2, new Vector3 (distance + 10f, _monster_spawn_height, 0), Quaternion.identity);
		}
		else if (waveNumber == 6) {
			Instantiate(MONSTER_TYPE_1, new Vector3 (distance + 4f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate(MONSTER_TYPE_1, new Vector3 (distance + 6f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate(MONSTER_TYPE_1, new Vector3 (distance + 8f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate(MONSTER_TYPE_2, new Vector3 (distance + 10f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate(MONSTER_TYPE_2, new Vector3 (distance + 12f, _monster_spawn_height, 0), Quaternion.identity);
			Instantiate(MONSTER_TYPE_2, new Vector3 (distance + 14f, _monster_spawn_height, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {

		var distance = transform.position.x - _start_pos;

		if(!_wave_1_spawned && distance > WAVE_1_DIST){
			_wave_1_spawned = true;
			_spawnWave (1, distance);
		}
		if(!_wave_2_spawned && distance > WAVE_2_DIST){
			_wave_2_spawned = true;
			_spawnWave (2, distance);
		}
		if(!_wave_3_spawned && distance > WAVE_3_DIST){
			_wave_3_spawned = true;
			_spawnWave (3, distance);
		}
		if(!_wave_4_spawned && distance > WAVE_4_DIST){
			_wave_4_spawned = true;
			_spawnWave (4, distance);
		}
		if(!_wave_5_spawned && distance > WAVE_5_DIST){
			_wave_5_spawned = true;
			_spawnWave (5, distance);
		}
		if(!_wave_6_spawned && distance > WAVE_6_DIST){
			_wave_6_spawned = true;
			_spawnWave (6, distance);
		}
	}
}
