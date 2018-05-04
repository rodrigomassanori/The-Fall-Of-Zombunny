namespace PlayerController
{
	using UnityEngine;

	public class CameraMark : MonoBehaviour
	{
		public Transform VisaoMark;

		public Camera CameraPlayer;

		void Awake()
		{
			VisaoMark = GetComponentInChildren<Transform>();

			CameraPlayer = GetComponentInChildren<Camera>();
		}

		void Update()
		{
			if (Physics.Linecast(CameraPlayer.transform.position, VisaoMark.transform.position))
			{
				transform.position = Vector3.Lerp(CameraPlayer.transform.position,
				VisaoMark.transform.position, 1.0f);
			}
		}
	}
}