﻿var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ZheXian');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);