namespace GrumpyOldDev.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('GrumpyOldDev');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}