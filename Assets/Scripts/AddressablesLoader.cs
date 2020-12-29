using UnityEngine;
using UnityEngine.UI;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets;
using System.Collections;

public class AddressablesLoader : MonoBehaviour
{
    [SerializeField] private AssetReference _loadableImage;
    [SerializeField] private Image _imageUI;
    
    private IEnumerator Start()
    {
        AsyncOperationHandle<Sprite> handle = _loadableImage.LoadAssetAsync<Sprite>();
        yield return handle;

        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
            _imageUI.sprite = handle.Result;
            Addressables.Release(handle);
        }
    }
}
