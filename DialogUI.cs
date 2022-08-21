using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EasyUI.Dialogs {

    public class Dialog {
        public string Title = "Title";
        public string Message = "Message";
    }

    public class DialogUI : MonoBehaviour {
        [SerializeField] GameObject canvas;
        [SerializeField] Text titleUIText;
        [SerializeField] Text messageUIText;
        [SerializeField] Button closeUIButton;

        Dialog dialog = new Dialog ( );

        // singleton pattern
        public static DialogUI Instance;

        void Awake() {
            Instance = this;

            // close event listener
            closeUIButton.onClick.RemoveAllListeners ();
            closeUIButton.onClick.AddListener ( Hide );
        }

        public DialogUI SetTitle ( string title ) {
            dialog.Title = title;
            return Instance;
        }

         public DialogUI SetMessage ( string message ) {
            dialog.Message = message;
            return Instance;
        }

        public void Show ( ) {
            titleUIText.text = dialog.Title;
            messageUIText.text = dialog.Message;
            // dialog = new Dialog ( );
            canvas.SetActive ( true );
        }

        public void Hide ( ) {
            canvas.SetActive ( false );
            dialog = new Dialog ( );
        }
    }

}


