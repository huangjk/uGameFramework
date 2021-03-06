/*block:using*/using /*name:name*/System/*endname*/;
/*endblock:using*/
using Zenject;
using UniRx;

namespace /*name:namespace*/Service.GeneratorPrototype/*endname*/ {
    class /*name:implName*/PrototypeServiceImpl/*endname*/ : /*name:serviceName*/PrototypeService/*endname*/ {
/*block:property*/
/*name:propAsString*/public override int MaxSoundChannels{get;set;}/*endname*/
/*endblock:property*/

        protected override void AfterInitialize() {
			// this is called right after the Base-Classes Initialize-Method. _eventManager and disposableManager are set
        }

/*block:method*/
		/*name:docs*/ //docs come here /*endname*/
		public override /*name:methodHead*/string DoPrototype(string settings="")/*endname*/ {
/*block:return*/            return default(/*name:returnType*/string/*endname*/);
/*endblock:return*/
        }
/*endblock:method*/ 

        protected override void OnDispose() {
            // do your IDispose-actions here. It is called right after disposables got disposed
        }

    }
}
