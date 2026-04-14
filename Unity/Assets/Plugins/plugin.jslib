var plugin = {
    OpenSameTab : function(url)
    {
        url = UTF8ToString(url);
        window.open(url,"_self");
    },


    SaveToLocalStorage: function (jsonString) {
        localStorage.setItem("reflectionsData", UTF8ToString(jsonString));
    },
    LoadFromLocalStorage: function () {
        var value = localStorage.getItem("reflectionsData");
        if (value === null) value = "";
        var lengthBytes = lengthBytesUTF8(value) + 1;
        var stringOnWasmHeap = _malloc(lengthBytes);
        stringToUTF8(value, stringOnWasmHeap, lengthBytes);
        return stringOnWasmHeap;
    },

};
mergeInto(LibraryManager.library, plugin);
