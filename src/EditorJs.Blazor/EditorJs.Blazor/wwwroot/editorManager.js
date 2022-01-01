
export function createEditor(editorConfigs){
    console.log(editorConfigs);
    const _editor =  new EditorJS({
        /**
         * Id of Element that should contain the Editor
         */
        holder: '123',

        /**
         * Available Tools list.
         * Pass Tool's class or Settings object for each Tool you want to use
         */


        autofocus: editorConfigs.autoFocus,
        onReady: () => {
            console.log('Editor.js is ready to work!')
        },
        onChange: (api, event) => {
            console.log('Now I know that Editor\'s content changed!', event)
        }
    });
    
}