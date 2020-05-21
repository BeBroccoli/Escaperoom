(function(){/*

 Copyright The Closure Library Authors.
 SPDX-License-Identifier: Apache-2.0
*/
var r;function aa(a){var b=0;return function(){return b<a.length?{done:!1,value:a[b++]}:{done:!0}}}
function t(a){var b="undefined"!=typeof Symbol&&Symbol.iterator&&a[Symbol.iterator];return b?b.call(a):{next:aa(a)}}
var ba="function"==typeof Object.create?Object.create:function(a){function b(){}
b.prototype=a;return new b},ca="function"==typeof Object.defineProperties?Object.defineProperty:function(a,b,c){if(a==Array.prototype||a==Object.prototype)return a;
a[b]=c.value;return a};
function ea(a){a=["object"==typeof globalThis&&globalThis,a,"object"==typeof window&&window,"object"==typeof self&&self,"object"==typeof global&&global];for(var b=0;b<a.length;++b){var c=a[b];if(c&&c.Math==Math)return c}throw Error("Cannot find global object");}
var fa=ea(this);function u(a,b){if(b){for(var c=fa,d=a.split("."),e=0;e<d.length-1;e++){var f=d[e];f in c||(c[f]={});c=c[f]}d=d[d.length-1];e=c[d];f=b(e);f!=e&&null!=f&&ca(c,d,{configurable:!0,writable:!0,value:f})}}
var ha;if("function"==typeof Object.setPrototypeOf)ha=Object.setPrototypeOf;else{var ia;a:{var ja={a:!0},ka={};try{ka.__proto__=ja;ia=ka.a;break a}catch(a){}ia=!1}ha=ia?function(a,b){a.__proto__=b;if(a.__proto__!==b)throw new TypeError(a+" is not extensible");return a}:null}var la=ha;
function ma(a,b){a.prototype=ba(b.prototype);a.prototype.constructor=a;if(la)la(a,b);else for(var c in b)if("prototype"!=c)if(Object.defineProperties){var d=Object.getOwnPropertyDescriptor(b,c);d&&Object.defineProperty(a,c,d)}else a[c]=b[c];a.w=b.prototype}
function na(a,b,c){if(null==a)throw new TypeError("The 'this' value for String.prototype."+c+" must not be null or undefined");if(b instanceof RegExp)throw new TypeError("First argument to String.prototype."+c+" must not be a regular expression");return a+""}
u("String.prototype.endsWith",function(a){return a?a:function(b,c){var d=na(this,b,"endsWith");b+="";void 0===c&&(c=d.length);for(var e=Math.max(0,Math.min(c|0,d.length)),f=b.length;0<f&&0<e;)if(d[--e]!=b[--f])return!1;return 0>=f}});
u("String.prototype.startsWith",function(a){return a?a:function(b,c){var d=na(this,b,"startsWith");b+="";for(var e=d.length,f=b.length,l=Math.max(0,Math.min(c|0,d.length)),g=0;g<f&&l<e;)if(d[l++]!=b[g++])return!1;return g>=f}});
u("Symbol",function(a){function b(e){if(this instanceof b)throw new TypeError("Symbol is not a constructor");return new c("jscomp_symbol_"+(e||"")+"_"+d++,e)}
function c(e,f){this.f=e;ca(this,"description",{configurable:!0,writable:!0,value:f})}
if(a)return a;c.prototype.toString=function(){return this.f};
var d=0;return b});
u("Symbol.iterator",function(a){if(a)return a;a=Symbol("Symbol.iterator");for(var b="Array Int8Array Uint8Array Uint8ClampedArray Int16Array Uint16Array Int32Array Uint32Array Float32Array Float64Array".split(" "),c=0;c<b.length;c++){var d=fa[b[c]];"function"===typeof d&&"function"!=typeof d.prototype[a]&&ca(d.prototype,a,{configurable:!0,writable:!0,value:function(){return oa(aa(this))}})}return a});
function oa(a){a={next:a};a[Symbol.iterator]=function(){return this};
return a}
function v(a,b){return Object.prototype.hasOwnProperty.call(a,b)}
var pa="function"==typeof Object.assign?Object.assign:function(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(d)for(var e in d)v(d,e)&&(a[e]=d[e])}return a};
u("Object.assign",function(a){return a||pa});
u("WeakMap",function(a){function b(h){this.f=(g+=Math.random()+1).toString();if(h){h=t(h);for(var k;!(k=h.next()).done;)k=k.value,this.set(k[0],k[1])}}
function c(){}
function d(h){var k=typeof h;return"object"===k&&null!==h||"function"===k}
function e(h){if(!v(h,l)){var k=new c;ca(h,l,{value:k})}}
function f(h){var k=Object[h];k&&(Object[h]=function(m){if(m instanceof c)return m;e(m);return k(m)})}
if(function(){if(!a||!Object.seal)return!1;try{var h=Object.seal({}),k=Object.seal({}),m=new a([[h,2],[k,3]]);if(2!=m.get(h)||3!=m.get(k))return!1;m["delete"](h);m.set(k,4);return!m.has(h)&&4==m.get(k)}catch(n){return!1}}())return a;
var l="$jscomp_hidden_"+Math.random();f("freeze");f("preventExtensions");f("seal");var g=0;b.prototype.set=function(h,k){if(!d(h))throw Error("Invalid WeakMap key");e(h);if(!v(h,l))throw Error("WeakMap key fail: "+h);h[l][this.f]=k;return this};
b.prototype.get=function(h){return d(h)&&v(h,l)?h[l][this.f]:void 0};
b.prototype.has=function(h){return d(h)&&v(h,l)&&v(h[l],this.f)};
b.prototype["delete"]=function(h){return d(h)&&v(h,l)&&v(h[l],this.f)?delete h[l][this.f]:!1};
return b});
u("Map",function(a){function b(){var g={};return g.previous=g.next=g.head=g}
function c(g,h){var k=g.f;return oa(function(){if(k){for(;k.head!=g.f;)k=k.previous;for(;k.next!=k.head;)return k=k.next,{done:!1,value:h(k)};k=null}return{done:!0,value:void 0}})}
function d(g,h){var k=h&&typeof h;"object"==k||"function"==k?f.has(h)?k=f.get(h):(k=""+ ++l,f.set(h,k)):k="p_"+h;var m=g.g[k];if(m&&v(g.g,k))for(var n=0;n<m.length;n++){var q=m[n];if(h!==h&&q.key!==q.key||h===q.key)return{id:k,list:m,index:n,j:q}}return{id:k,list:m,index:-1,j:void 0}}
function e(g){this.g={};this.f=b();this.size=0;if(g){g=t(g);for(var h;!(h=g.next()).done;)h=h.value,this.set(h[0],h[1])}}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var g=Object.seal({x:4}),h=new a(t([[g,"s"]]));if("s"!=h.get(g)||1!=h.size||h.get({x:4})||h.set({x:4},"t")!=h||2!=h.size)return!1;var k=h.entries(),m=k.next();if(m.done||m.value[0]!=g||"s"!=m.value[1])return!1;m=k.next();return m.done||4!=m.value[0].x||"t"!=m.value[1]||!k.next().done?!1:!0}catch(n){return!1}}())return a;
var f=new WeakMap;e.prototype.set=function(g,h){g=0===g?0:g;var k=d(this,g);k.list||(k.list=this.g[k.id]=[]);k.j?k.j.value=h:(k.j={next:this.f,previous:this.f.previous,head:this.f,key:g,value:h},k.list.push(k.j),this.f.previous.next=k.j,this.f.previous=k.j,this.size++);return this};
e.prototype["delete"]=function(g){g=d(this,g);return g.j&&g.list?(g.list.splice(g.index,1),g.list.length||delete this.g[g.id],g.j.previous.next=g.j.next,g.j.next.previous=g.j.previous,g.j.head=null,this.size--,!0):!1};
e.prototype.clear=function(){this.g={};this.f=this.f.previous=b();this.size=0};
e.prototype.has=function(g){return!!d(this,g).j};
e.prototype.get=function(g){return(g=d(this,g).j)&&g.value};
e.prototype.entries=function(){return c(this,function(g){return[g.key,g.value]})};
e.prototype.keys=function(){return c(this,function(g){return g.key})};
e.prototype.values=function(){return c(this,function(g){return g.value})};
e.prototype.forEach=function(g,h){for(var k=this.entries(),m;!(m=k.next()).done;)m=m.value,g.call(h,m[1],m[0],this)};
e.prototype[Symbol.iterator]=e.prototype.entries;var l=0;return e});
u("Object.entries",function(a){return a?a:function(b){var c=[],d;for(d in b)v(b,d)&&c.push([d,b[d]]);return c}});
u("String.prototype.includes",function(a){return a?a:function(b,c){return-1!==na(this,b,"includes").indexOf(b,c||0)}});
u("Set",function(a){function b(c){this.f=new Map;if(c){c=t(c);for(var d;!(d=c.next()).done;)this.add(d.value)}this.size=this.f.size}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var c=Object.seal({x:4}),d=new a(t([c]));if(!d.has(c)||1!=d.size||d.add(c)!=d||1!=d.size||d.add({x:4})!=d||2!=d.size)return!1;var e=d.entries(),f=e.next();if(f.done||f.value[0]!=c||f.value[1]!=c)return!1;f=e.next();return f.done||f.value[0]==c||4!=f.value[0].x||f.value[1]!=f.value[0]?!1:e.next().done}catch(l){return!1}}())return a;
b.prototype.add=function(c){c=0===c?0:c;this.f.set(c,c);this.size=this.f.size;return this};
b.prototype["delete"]=function(c){c=this.f["delete"](c);this.size=this.f.size;return c};
b.prototype.clear=function(){this.f.clear();this.size=0};
b.prototype.has=function(c){return this.f.has(c)};
b.prototype.entries=function(){return this.f.entries()};
b.prototype.values=function(){return this.f.values()};
b.prototype.keys=b.prototype.values;b.prototype[Symbol.iterator]=b.prototype.values;b.prototype.forEach=function(c,d){var e=this;this.f.forEach(function(f){return c.call(d,f,f,e)})};
return b});
var x=this||self;function y(a,b){for(var c=a.split("."),d=b||x,e=0;e<c.length;e++)if(d=d[c[e]],null==d)return null;return d}
function qa(){}
function ra(a){var b=typeof a;if("object"==b)if(a){if(a instanceof Array)return"array";if(a instanceof Object)return b;var c=Object.prototype.toString.call(a);if("[object Window]"==c)return"object";if("[object Array]"==c||"number"==typeof a.length&&"undefined"!=typeof a.splice&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("splice"))return"array";if("[object Function]"==c||"undefined"!=typeof a.call&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("call"))return"function"}else return"null";
else if("function"==b&&"undefined"==typeof a.call)return"object";return b}
function sa(a){var b=ra(a);return"array"==b||"object"==b&&"number"==typeof a.length}
function ta(a){return"function"==ra(a)}
function ua(a){var b=typeof a;return"object"==b&&null!=a||"function"==b}
function va(a){return Object.prototype.hasOwnProperty.call(a,wa)&&a[wa]||(a[wa]=++xa)}
var wa="closure_uid_"+(1E9*Math.random()>>>0),xa=0;function za(a,b,c){return a.call.apply(a.bind,arguments)}
function Aa(a,b,c){if(!a)throw Error();if(2<arguments.length){var d=Array.prototype.slice.call(arguments,2);return function(){var e=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(e,d);return a.apply(b,e)}}return function(){return a.apply(b,arguments)}}
function z(a,b,c){Function.prototype.bind&&-1!=Function.prototype.bind.toString().indexOf("native code")?z=za:z=Aa;return z.apply(null,arguments)}
var B=Date.now||function(){return+new Date};
function C(a,b){var c=a.split("."),d=x;c[0]in d||"undefined"==typeof d.execScript||d.execScript("var "+c[0]);for(var e;c.length&&(e=c.shift());)c.length||void 0===b?d[e]&&d[e]!==Object.prototype[e]?d=d[e]:d=d[e]={}:d[e]=b}
function D(a,b){function c(){}
c.prototype=b.prototype;a.w=b.prototype;a.prototype=new c;a.prototype.constructor=a}
;var Ba=Array.prototype.indexOf?function(a,b){return Array.prototype.indexOf.call(a,b,void 0)}:function(a,b){if("string"===typeof a)return"string"!==typeof b||1!=b.length?-1:a.indexOf(b,0);
for(var c=0;c<a.length;c++)if(c in a&&a[c]===b)return c;return-1},E=Array.prototype.forEach?function(a,b,c){Array.prototype.forEach.call(a,b,c)}:function(a,b,c){for(var d=a.length,e="string"===typeof a?a.split(""):a,f=0;f<d;f++)f in e&&b.call(c,e[f],f,a)},Ca=Array.prototype.reduce?function(a,b,c){return Array.prototype.reduce.call(a,b,c)}:function(a,b,c){var d=c;
E(a,function(e,f){d=b.call(void 0,d,e,f,a)});
return d};
function Da(a,b){a:{var c=a.length;for(var d="string"===typeof a?a.split(""):a,e=0;e<c;e++)if(e in d&&b.call(void 0,d[e],e,a)){c=e;break a}c=-1}return 0>c?null:"string"===typeof a?a.charAt(c):a[c]}
function Ea(a){return Array.prototype.concat.apply([],arguments)}
function Fa(a){var b=a.length;if(0<b){for(var c=Array(b),d=0;d<b;d++)c[d]=a[d];return c}return[]}
function Ga(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(sa(d)){var e=a.length||0,f=d.length||0;a.length=e+f;for(var l=0;l<f;l++)a[e+l]=d[l]}else a.push(d)}}
;function Ha(a){var b=!1,c;return function(){b||(c=a(),b=!0);return c}}
;function Ia(a,b){for(var c in a)b.call(void 0,a[c],c,a)}
function Ja(a){var b=F,c;for(c in b)if(a.call(void 0,b[c],c,b))return c}
function Ka(a,b){for(var c in a)if(!(c in b)||a[c]!==b[c])return!1;for(var d in b)if(!(d in a))return!1;return!0}
function La(a){var b=ra(a);if("object"==b||"array"==b){if(ta(a.clone))return a.clone();b="array"==b?[]:{};for(var c in a)b[c]=La(a[c]);return b}return a}
var Ma="constructor hasOwnProperty isPrototypeOf propertyIsEnumerable toLocaleString toString valueOf".split(" ");function Na(a,b){for(var c,d,e=1;e<arguments.length;e++){d=arguments[e];for(c in d)a[c]=d[c];for(var f=0;f<Ma.length;f++)c=Ma[f],Object.prototype.hasOwnProperty.call(d,c)&&(a[c]=d[c])}}
;var Oa=String.prototype.trim?function(a){return a.trim()}:function(a){return/^[\s\xa0]*([\s\S]*?)[\s\xa0]*$/.exec(a)[1]},Pa=/&/g,Qa=/</g,Ra=/>/g,Sa=/"/g,Ta=/'/g,Ua=/\x00/g,Va=/[\x00&<>"']/;var Wa;a:{var Xa=x.navigator;if(Xa){var Ya=Xa.userAgent;if(Ya){Wa=Ya;break a}}Wa=""}function G(a){return-1!=Wa.indexOf(a)}
;function Za(){}
;var $a=G("Opera"),ab=G("Trident")||G("MSIE"),bb=G("Edge"),cb=G("Gecko")&&!(-1!=Wa.toLowerCase().indexOf("webkit")&&!G("Edge"))&&!(G("Trident")||G("MSIE"))&&!G("Edge"),db=-1!=Wa.toLowerCase().indexOf("webkit")&&!G("Edge");function eb(){var a=x.document;return a?a.documentMode:void 0}
var gb;a:{var hb="",ib=function(){var a=Wa;if(cb)return/rv:([^\);]+)(\)|;)/.exec(a);if(bb)return/Edge\/([\d\.]+)/.exec(a);if(ab)return/\b(?:MSIE|rv)[: ]([^\);]+)(\)|;)/.exec(a);if(db)return/WebKit\/(\S+)/.exec(a);if($a)return/(?:Version)[ \/]?(\S+)/.exec(a)}();
ib&&(hb=ib?ib[1]:"");if(ab){var jb=eb();if(null!=jb&&jb>parseFloat(hb)){gb=String(jb);break a}}gb=hb}var kb=gb,lb;if(x.document&&ab){var mb=eb();lb=mb?mb:parseInt(kb,10)||void 0}else lb=void 0;var nb=lb;var ob={},pb=null;var H=window;function qb(a){var b=y("window.location.href");null==a&&(a='Unknown Error of type "null/undefined"');if("string"===typeof a)return{message:a,name:"Unknown error",lineNumber:"Not available",fileName:b,stack:"Not available"};var c=!1;try{var d=a.lineNumber||a.line||"Not available"}catch(f){d="Not available",c=!0}try{var e=a.fileName||a.filename||a.sourceURL||x.$googDebugFname||b}catch(f){e="Not available",c=!0}return!c&&a.lineNumber&&a.fileName&&a.stack&&a.message&&a.name?a:(b=a.message,null==b&&(a.constructor&&
a.constructor instanceof Function?(a.constructor.name?b=a.constructor.name:(b=a.constructor,rb[b]?b=rb[b]:(b=String(b),rb[b]||(c=/function\s+([^\(]+)/m.exec(b),rb[b]=c?c[1]:"[Anonymous]"),b=rb[b])),b='Unknown Error of type "'+b+'"'):b="Unknown Error of unknown type"),{message:b,name:a.name||"UnknownError",lineNumber:d,fileName:e,stack:a.stack||"Not available"})}
var rb={};function sb(a){this.f=a||{cookie:""}}
r=sb.prototype;r.isEnabled=function(){return navigator.cookieEnabled};
r.set=function(a,b,c){var d=!1;if("object"===typeof c){var e=c.ya;d=c.secure||!1;var f=c.domain||void 0;var l=c.path||void 0;var g=c.L}if(/[;=\s]/.test(a))throw Error('Invalid cookie name "'+a+'"');if(/[;\r\n]/.test(b))throw Error('Invalid cookie value "'+b+'"');void 0===g&&(g=-1);c=f?";domain="+f:"";l=l?";path="+l:"";d=d?";secure":"";g=0>g?"":0==g?";expires="+(new Date(1970,1,1)).toUTCString():";expires="+(new Date(B()+1E3*g)).toUTCString();this.f.cookie=a+"="+b+c+l+g+d+(null!=e?";samesite="+e:"")};
r.get=function(a,b){for(var c=a+"=",d=(this.f.cookie||"").split(";"),e=0,f;e<d.length;e++){f=Oa(d[e]);if(0==f.lastIndexOf(c,0))return f.substr(c.length);if(f==a)return""}return b};
r.remove=function(a,b,c){var d=void 0!==this.get(a);this.set(a,"",{L:0,path:b,domain:c});return d};
r.isEmpty=function(){return!this.f.cookie};
r.clear=function(){for(var a=(this.f.cookie||"").split(";"),b=[],c=[],d,e,f=0;f<a.length;f++)e=Oa(a[f]),d=e.indexOf("="),-1==d?(b.push(""),c.push(e)):(b.push(e.substring(0,d)),c.push(e.substring(d+1)));for(a=b.length-1;0<=a;a--)this.remove(b[a])};
var tb=new sb("undefined"==typeof document?null:document);function ub(a,b){this.width=a;this.height=b}
r=ub.prototype;r.clone=function(){return new ub(this.width,this.height)};
r.aspectRatio=function(){return this.width/this.height};
r.isEmpty=function(){return!(this.width*this.height)};
r.ceil=function(){this.width=Math.ceil(this.width);this.height=Math.ceil(this.height);return this};
r.floor=function(){this.width=Math.floor(this.width);this.height=Math.floor(this.height);return this};
r.round=function(){this.width=Math.round(this.width);this.height=Math.round(this.height);return this};function vb(a,b){var c,d;var e=document;e=b||e;if(e.querySelectorAll&&e.querySelector&&a)return e.querySelectorAll(a?"."+a:"");if(a&&e.getElementsByClassName){var f=e.getElementsByClassName(a);return f}f=e.getElementsByTagName("*");if(a){var l={};for(c=d=0;e=f[c];c++){var g=e.className,h;if(h="function"==typeof g.split)h=0<=Ba(g.split(/\s+/),a);h&&(l[d++]=e)}l.length=d;return l}return f}
function wb(){var a=document;var b="IFRAME";"application/xhtml+xml"===a.contentType&&(b=b.toLowerCase());return a.createElement(b)}
function xb(a,b){for(var c=0;a;){if(b(a))return a;a=a.parentNode;c++}return null}
;var yb=/^(?:([^:/?#.]+):)?(?:\/\/(?:([^\\/?#]*)@)?([^\\/?#]*?)(?::([0-9]+))?(?=[\\/?#]|$))?([^?#]+)?(?:\?([^#]*))?(?:#([\s\S]*))?$/;function I(a){return a.match(yb)}
function J(a){return a?decodeURI(a):a}
function zb(a){var b=I(a);a=b[1];var c=b[2],d=b[3];b=b[4];var e="";a&&(e+=a+":");d&&(e+="//",c&&(e+=c+"@"),e+=d,b&&(e+=":"+b));return e}
function Ab(a,b,c){if(Array.isArray(b))for(var d=0;d<b.length;d++)Ab(a,String(b[d]),c);else null!=b&&c.push(a+(""===b?"":"="+encodeURIComponent(String(b))))}
function Bb(a){var b=[],c;for(c in a)Ab(c,a[c],b);return b.join("&")}
var Cb=/#|$/;function Db(a){var b=Eb;if(b)for(var c in b)Object.prototype.hasOwnProperty.call(b,c)&&a.call(void 0,b[c],c,b)}
function Fb(){var a=[];Db(function(b){a.push(b)});
return a}
var Eb={fa:"allow-forms",ga:"allow-modals",ha:"allow-orientation-lock",ia:"allow-pointer-lock",ja:"allow-popups",ka:"allow-popups-to-escape-sandbox",la:"allow-presentation",ma:"allow-same-origin",na:"allow-scripts",oa:"allow-top-navigation",pa:"allow-top-navigation-by-user-activation"},Gb=Ha(function(){return Fb()});
function Hb(){var a=wb(),b={};E(Gb(),function(c){a.sandbox&&a.sandbox.supports&&a.sandbox.supports(c)&&(b[c]=!0)});
return b}
;function Ib(){this.h=this.h;this.i=this.i}
Ib.prototype.h=!1;Ib.prototype.dispose=function(){this.h||(this.h=!0,this.G())};
Ib.prototype.G=function(){if(this.i)for(;this.i.length;)this.i.shift()()};var Jb=(new Date).getTime();function Kb(a){if(!a)return"";a=a.split("#")[0].split("?")[0];a=a.toLowerCase();0==a.indexOf("//")&&(a=window.location.protocol+a);/^[\w\-]*:\/\//.test(a)||(a=window.location.href);var b=a.substring(a.indexOf("://")+3),c=b.indexOf("/");-1!=c&&(b=b.substring(0,c));a=a.substring(0,a.indexOf("://"));if("http"!==a&&"https"!==a&&"chrome-extension"!==a&&"file"!==a&&"android-app"!==a&&"chrome-search"!==a&&"chrome-untrusted"!==a&&"chrome"!==a&&"app"!==a)throw Error("Invalid URI scheme in origin: "+a);c="";
var d=b.indexOf(":");if(-1!=d){var e=b.substring(d+1);b=b.substring(0,d);if("http"===a&&"80"!==e||"https"===a&&"443"!==e)c=":"+e}return a+"://"+b+c}
;function Lb(){function a(){e[0]=1732584193;e[1]=4023233417;e[2]=2562383102;e[3]=271733878;e[4]=3285377520;m=k=0}
function b(n){for(var q=l,p=0;64>p;p+=4)q[p/4]=n[p]<<24|n[p+1]<<16|n[p+2]<<8|n[p+3];for(p=16;80>p;p++)n=q[p-3]^q[p-8]^q[p-14]^q[p-16],q[p]=(n<<1|n>>>31)&4294967295;n=e[0];var w=e[1],A=e[2],R=e[3],fb=e[4];for(p=0;80>p;p++){if(40>p)if(20>p){var da=R^w&(A^R);var ya=1518500249}else da=w^A^R,ya=1859775393;else 60>p?(da=w&A|R&(w|A),ya=2400959708):(da=w^A^R,ya=3395469782);da=((n<<5|n>>>27)&4294967295)+da+fb+ya+q[p]&4294967295;fb=R;R=A;A=(w<<30|w>>>2)&4294967295;w=n;n=da}e[0]=e[0]+n&4294967295;e[1]=e[1]+
w&4294967295;e[2]=e[2]+A&4294967295;e[3]=e[3]+R&4294967295;e[4]=e[4]+fb&4294967295}
function c(n,q){if("string"===typeof n){n=unescape(encodeURIComponent(n));for(var p=[],w=0,A=n.length;w<A;++w)p.push(n.charCodeAt(w));n=p}q||(q=n.length);p=0;if(0==k)for(;p+64<q;)b(n.slice(p,p+64)),p+=64,m+=64;for(;p<q;)if(f[k++]=n[p++],m++,64==k)for(k=0,b(f);p+64<q;)b(n.slice(p,p+64)),p+=64,m+=64}
function d(){var n=[],q=8*m;56>k?c(g,56-k):c(g,64-(k-56));for(var p=63;56<=p;p--)f[p]=q&255,q>>>=8;b(f);for(p=q=0;5>p;p++)for(var w=24;0<=w;w-=8)n[q++]=e[p]>>w&255;return n}
for(var e=[],f=[],l=[],g=[128],h=1;64>h;++h)g[h]=0;var k,m;a();return{reset:a,update:c,digest:d,V:function(){for(var n=d(),q="",p=0;p<n.length;p++)q+="0123456789ABCDEF".charAt(Math.floor(n[p]/16))+"0123456789ABCDEF".charAt(n[p]%16);return q}}}
;function Mb(a,b,c){var d=[],e=[];if(1==(Array.isArray(c)?2:1))return e=[b,a],E(d,function(g){e.push(g)}),Nb(e.join(" "));
var f=[],l=[];E(c,function(g){l.push(g.key);f.push(g.value)});
c=Math.floor((new Date).getTime()/1E3);e=0==f.length?[c,b,a]:[f.join(":"),c,b,a];E(d,function(g){e.push(g)});
a=Nb(e.join(" "));a=[c,a];0==l.length||a.push(l.join(""));return a.join("_")}
function Nb(a){var b=Lb();b.update(a);return b.V().toLowerCase()}
;function Ob(a){var b=Kb(String(x.location.href)),c;(c=x.__SAPISID||x.__APISID||x.__OVERRIDE_SID)?c=!0:(c=new sb(document),c=c.get("SAPISID")||c.get("APISID")||c.get("__Secure-3PAPISID")||c.get("SID"),c=!!c);if(c&&(c=(b=0==b.indexOf("https:")||0==b.indexOf("chrome-extension:"))?x.__SAPISID:x.__APISID,c||(c=new sb(document),c=c.get(b?"SAPISID":"APISID")||c.get("__Secure-3PAPISID")),c)){b=b?"SAPISIDHASH":"APISIDHASH";var d=String(x.location.href);return d&&c&&b?[b,Mb(Kb(d),c,a||null)].join(" "):null}return null}
;function Pb(){this.g=[];this.f=-1}
Pb.prototype.set=function(a,b){b=void 0===b?!0:b;0<=a&&52>a&&0===a%1&&this.g[a]!=b&&(this.g[a]=b,this.f=-1)};
Pb.prototype.get=function(a){return!!this.g[a]};
function Qb(a){-1==a.f&&(a.f=Ca(a.g,function(b,c,d){return c?b+Math.pow(2,d):b},0));
return a.f}
;function Rb(a,b){this.h=a;this.i=b;this.g=0;this.f=null}
Rb.prototype.get=function(){if(0<this.g){this.g--;var a=this.f;this.f=a.next;a.next=null}else a=this.h();return a};function Sb(a){x.setTimeout(function(){throw a;},0)}
var Tb;function Ub(){var a=x.MessageChannel;"undefined"===typeof a&&"undefined"!==typeof window&&window.postMessage&&window.addEventListener&&!G("Presto")&&(a=function(){var e=wb();e.style.display="none";document.documentElement.appendChild(e);var f=e.contentWindow;e=f.document;e.open();e.close();var l="callImmediate"+Math.random(),g="file:"==f.location.protocol?"*":f.location.protocol+"//"+f.location.host;e=z(function(h){if(("*"==g||h.origin==g)&&h.data==l)this.port1.onmessage()},this);
f.addEventListener("message",e,!1);this.port1={};this.port2={postMessage:function(){f.postMessage(l,g)}}});
if("undefined"!==typeof a&&!G("Trident")&&!G("MSIE")){var b=new a,c={},d=c;b.port1.onmessage=function(){if(void 0!==c.next){c=c.next;var e=c.K;c.K=null;e()}};
return function(e){d.next={K:e};d=d.next;b.port2.postMessage(0)}}return function(e){x.setTimeout(e,0)}}
;function Vb(){this.g=this.f=null}
var Xb=new Rb(function(){return new Wb},function(a){a.reset()});
Vb.prototype.add=function(a,b){var c=Xb.get();c.set(a,b);this.g?this.g.next=c:this.f=c;this.g=c};
Vb.prototype.remove=function(){var a=null;this.f&&(a=this.f,this.f=this.f.next,this.f||(this.g=null),a.next=null);return a};
function Wb(){this.next=this.scope=this.f=null}
Wb.prototype.set=function(a,b){this.f=a;this.scope=b;this.next=null};
Wb.prototype.reset=function(){this.next=this.scope=this.f=null};function Yb(a){Zb||$b();ac||(Zb(),ac=!0);bc.add(a,void 0)}
var Zb;function $b(){if(x.Promise&&x.Promise.resolve){var a=x.Promise.resolve(void 0);Zb=function(){a.then(cc)}}else Zb=function(){var b=cc;
!ta(x.setImmediate)||x.Window&&x.Window.prototype&&!G("Edge")&&x.Window.prototype.setImmediate==x.setImmediate?(Tb||(Tb=Ub()),Tb(b)):x.setImmediate(b)}}
var ac=!1,bc=new Vb;function cc(){for(var a;a=bc.remove();){try{a.f.call(a.scope)}catch(c){Sb(c)}var b=Xb;b.i(a);100>b.g&&(b.g++,a.next=b.f,b.f=a)}ac=!1}
;function dc(){this.g=-1}
;function ec(){this.g=64;this.f=[];this.m=[];this.u=[];this.i=[];this.i[0]=128;for(var a=1;a<this.g;++a)this.i[a]=0;this.l=this.h=0;this.reset()}
D(ec,dc);ec.prototype.reset=function(){this.f[0]=1732584193;this.f[1]=4023233417;this.f[2]=2562383102;this.f[3]=271733878;this.f[4]=3285377520;this.l=this.h=0};
function fc(a,b,c){c||(c=0);var d=a.u;if("string"===typeof b)for(var e=0;16>e;e++)d[e]=b.charCodeAt(c)<<24|b.charCodeAt(c+1)<<16|b.charCodeAt(c+2)<<8|b.charCodeAt(c+3),c+=4;else for(e=0;16>e;e++)d[e]=b[c]<<24|b[c+1]<<16|b[c+2]<<8|b[c+3],c+=4;for(e=16;80>e;e++){var f=d[e-3]^d[e-8]^d[e-14]^d[e-16];d[e]=(f<<1|f>>>31)&4294967295}b=a.f[0];c=a.f[1];var l=a.f[2],g=a.f[3],h=a.f[4];for(e=0;80>e;e++){if(40>e)if(20>e){f=g^c&(l^g);var k=1518500249}else f=c^l^g,k=1859775393;else 60>e?(f=c&l|g&(c|l),k=2400959708):
(f=c^l^g,k=3395469782);f=(b<<5|b>>>27)+f+h+k+d[e]&4294967295;h=g;g=l;l=(c<<30|c>>>2)&4294967295;c=b;b=f}a.f[0]=a.f[0]+b&4294967295;a.f[1]=a.f[1]+c&4294967295;a.f[2]=a.f[2]+l&4294967295;a.f[3]=a.f[3]+g&4294967295;a.f[4]=a.f[4]+h&4294967295}
ec.prototype.update=function(a,b){if(null!=a){void 0===b&&(b=a.length);for(var c=b-this.g,d=0,e=this.m,f=this.h;d<b;){if(0==f)for(;d<=c;)fc(this,a,d),d+=this.g;if("string"===typeof a)for(;d<b;){if(e[f]=a.charCodeAt(d),++f,++d,f==this.g){fc(this,e);f=0;break}}else for(;d<b;)if(e[f]=a[d],++f,++d,f==this.g){fc(this,e);f=0;break}}this.h=f;this.l+=b}};
ec.prototype.digest=function(){var a=[],b=8*this.l;56>this.h?this.update(this.i,56-this.h):this.update(this.i,this.g-(this.h-56));for(var c=this.g-1;56<=c;c--)this.m[c]=b&255,b/=256;fc(this,this.m);for(c=b=0;5>c;c++)for(var d=24;0<=d;d-=8)a[b]=this.f[c]>>d&255,++b;return a};var K="StopIteration"in x?x.StopIteration:{message:"StopIteration",stack:""};function L(){}
L.prototype.next=function(){throw K;};
L.prototype.s=function(){return this};
function gc(a){if(a instanceof L)return a;if("function"==typeof a.s)return a.s(!1);if(sa(a)){var b=0,c=new L;c.next=function(){for(;;){if(b>=a.length)throw K;if(b in a)return a[b++];b++}};
return c}throw Error("Not implemented");}
function hc(a,b){if(sa(a))try{E(a,b,void 0)}catch(c){if(c!==K)throw c;}else{a=gc(a);try{for(;;)b.call(void 0,a.next(),void 0,a)}catch(c){if(c!==K)throw c;}}}
function ic(a){if(sa(a))return Fa(a);a=gc(a);var b=[];hc(a,function(c){b.push(c)});
return b}
;function jc(a,b){this.h={};this.f=[];this.i=this.g=0;var c=arguments.length;if(1<c){if(c%2)throw Error("Uneven number of arguments");for(var d=0;d<c;d+=2)this.set(arguments[d],arguments[d+1])}else if(a)if(a instanceof jc)for(c=kc(a),d=0;d<c.length;d++)this.set(c[d],a.get(c[d]));else for(d in a)this.set(d,a[d])}
function kc(a){lc(a);return a.f.concat()}
r=jc.prototype;r.equals=function(a,b){if(this===a)return!0;if(this.g!=a.g)return!1;var c=b||mc;lc(this);for(var d,e=0;d=this.f[e];e++)if(!c(this.get(d),a.get(d)))return!1;return!0};
function mc(a,b){return a===b}
r.isEmpty=function(){return 0==this.g};
r.clear=function(){this.h={};this.i=this.g=this.f.length=0};
r.remove=function(a){return Object.prototype.hasOwnProperty.call(this.h,a)?(delete this.h[a],this.g--,this.i++,this.f.length>2*this.g&&lc(this),!0):!1};
function lc(a){if(a.g!=a.f.length){for(var b=0,c=0;b<a.f.length;){var d=a.f[b];Object.prototype.hasOwnProperty.call(a.h,d)&&(a.f[c++]=d);b++}a.f.length=c}if(a.g!=a.f.length){var e={};for(c=b=0;b<a.f.length;)d=a.f[b],Object.prototype.hasOwnProperty.call(e,d)||(a.f[c++]=d,e[d]=1),b++;a.f.length=c}}
r.get=function(a,b){return Object.prototype.hasOwnProperty.call(this.h,a)?this.h[a]:b};
r.set=function(a,b){Object.prototype.hasOwnProperty.call(this.h,a)||(this.g++,this.f.push(a),this.i++);this.h[a]=b};
r.forEach=function(a,b){for(var c=kc(this),d=0;d<c.length;d++){var e=c[d],f=this.get(e);a.call(b,f,e,this)}};
r.clone=function(){return new jc(this)};
r.s=function(a){lc(this);var b=0,c=this.i,d=this,e=new L;e.next=function(){if(c!=d.i)throw Error("The map has changed since the iterator was created");if(b>=d.f.length)throw K;var f=d.f[b++];return a?f:d.h[f]};
return e};var nc=x.JSON.stringify;function M(a){Ib.call(this);this.u=1;this.l=[];this.m=0;this.f=[];this.g={};this.A=!!a}
D(M,Ib);r=M.prototype;r.subscribe=function(a,b,c){var d=this.g[a];d||(d=this.g[a]=[]);var e=this.u;this.f[e]=a;this.f[e+1]=b;this.f[e+2]=c;this.u=e+3;d.push(e);return e};
function oc(a,b,c){var d=pc;if(a=d.g[a]){var e=d.f;(a=Da(a,function(f){return e[f+1]==b&&e[f+2]==c}))&&d.C(a)}}
r.C=function(a){var b=this.f[a];if(b){var c=this.g[b];if(0!=this.m)this.l.push(a),this.f[a+1]=qa;else{if(c){var d=Ba(c,a);0<=d&&Array.prototype.splice.call(c,d,1)}delete this.f[a];delete this.f[a+1];delete this.f[a+2]}}return!!b};
r.I=function(a,b){var c=this.g[a];if(c){for(var d=Array(arguments.length-1),e=1,f=arguments.length;e<f;e++)d[e-1]=arguments[e];if(this.A)for(e=0;e<c.length;e++){var l=c[e];qc(this.f[l+1],this.f[l+2],d)}else{this.m++;try{for(e=0,f=c.length;e<f;e++)l=c[e],this.f[l+1].apply(this.f[l+2],d)}finally{if(this.m--,0<this.l.length&&0==this.m)for(;c=this.l.pop();)this.C(c)}}return 0!=e}return!1};
function qc(a,b,c){Yb(function(){a.apply(b,c)})}
r.clear=function(a){if(a){var b=this.g[a];b&&(E(b,this.C,this),delete this.g[a])}else this.f.length=0,this.g={}};
r.G=function(){M.w.G.call(this);this.clear();this.l.length=0};function rc(a){this.f=a}
rc.prototype.set=function(a,b){void 0===b?this.f.remove(a):this.f.set(a,nc(b))};
rc.prototype.get=function(a){try{var b=this.f.get(a)}catch(c){return}if(null!==b)try{return JSON.parse(b)}catch(c){throw"Storage: Invalid value was encountered";}};
rc.prototype.remove=function(a){this.f.remove(a)};function N(a){this.f=a}
D(N,rc);function sc(a){this.data=a}
function tc(a){return void 0===a||a instanceof sc?a:new sc(a)}
N.prototype.set=function(a,b){N.w.set.call(this,a,tc(b))};
N.prototype.g=function(a){a=N.w.get.call(this,a);if(void 0===a||a instanceof Object)return a;throw"Storage: Invalid value was encountered";};
N.prototype.get=function(a){if(a=this.g(a)){if(a=a.data,void 0===a)throw"Storage: Invalid value was encountered";}else a=void 0;return a};function O(a){this.f=a}
D(O,N);O.prototype.set=function(a,b,c){if(b=tc(b)){if(c){if(c<B()){O.prototype.remove.call(this,a);return}b.expiration=c}b.creation=B()}O.w.set.call(this,a,b)};
O.prototype.g=function(a){var b=O.w.g.call(this,a);if(b){var c=b.creation,d=b.expiration;if(d&&d<B()||c&&c>B())O.prototype.remove.call(this,a);else return b}};function uc(){}
;function vc(){}
D(vc,uc);vc.prototype.clear=function(){var a=ic(this.s(!0)),b=this;E(a,function(c){b.remove(c)})};function wc(a){this.f=a}
D(wc,vc);r=wc.prototype;r.isAvailable=function(){if(!this.f)return!1;try{return this.f.setItem("__sak","1"),this.f.removeItem("__sak"),!0}catch(a){return!1}};
r.set=function(a,b){try{this.f.setItem(a,b)}catch(c){if(0==this.f.length)throw"Storage mechanism: Storage disabled";throw"Storage mechanism: Quota exceeded";}};
r.get=function(a){a=this.f.getItem(a);if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
r.remove=function(a){this.f.removeItem(a)};
r.s=function(a){var b=0,c=this.f,d=new L;d.next=function(){if(b>=c.length)throw K;var e=c.key(b++);if(a)return e;e=c.getItem(e);if("string"!==typeof e)throw"Storage mechanism: Invalid value was encountered";return e};
return d};
r.clear=function(){this.f.clear()};
r.key=function(a){return this.f.key(a)};function xc(){var a=null;try{a=window.localStorage||null}catch(b){}this.f=a}
D(xc,wc);function yc(a,b){this.g=a;this.f=null;var c;if(c=ab)c=!(9<=Number(nb));if(c){zc||(zc=new jc);this.f=zc.get(a);this.f||(b?this.f=document.getElementById(b):(this.f=document.createElement("userdata"),this.f.addBehavior("#default#userData"),document.body.appendChild(this.f)),zc.set(a,this.f));try{this.f.load(this.g)}catch(d){this.f=null}}}
D(yc,vc);var Ac={".":".2E","!":".21","~":".7E","*":".2A","'":".27","(":".28",")":".29","%":"."},zc=null;function Bc(a){return"_"+encodeURIComponent(a).replace(/[.!~*'()%]/g,function(b){return Ac[b]})}
r=yc.prototype;r.isAvailable=function(){return!!this.f};
r.set=function(a,b){this.f.setAttribute(Bc(a),b);Cc(this)};
r.get=function(a){a=this.f.getAttribute(Bc(a));if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
r.remove=function(a){this.f.removeAttribute(Bc(a));Cc(this)};
r.s=function(a){var b=0,c=this.f.XMLDocument.documentElement.attributes,d=new L;d.next=function(){if(b>=c.length)throw K;var e=c[b++];if(a)return decodeURIComponent(e.nodeName.replace(/\./g,"%")).substr(1);e=e.nodeValue;if("string"!==typeof e)throw"Storage mechanism: Invalid value was encountered";return e};
return d};
r.clear=function(){for(var a=this.f.XMLDocument.documentElement,b=a.attributes.length;0<b;b--)a.removeAttribute(a.attributes[b-1].nodeName);Cc(this)};
function Cc(a){try{a.f.save(a.g)}catch(b){throw"Storage mechanism: Quota exceeded";}}
;function Dc(a,b){this.g=a;this.f=b+"::"}
D(Dc,vc);Dc.prototype.set=function(a,b){this.g.set(this.f+a,b)};
Dc.prototype.get=function(a){return this.g.get(this.f+a)};
Dc.prototype.remove=function(a){this.g.remove(this.f+a)};
Dc.prototype.s=function(a){var b=this.g.s(!0),c=this,d=new L;d.next=function(){for(var e=b.next();e.substr(0,c.f.length)!=c.f;)e=b.next();return a?e.substr(c.f.length):c.g.get(e)};
return d};var P=window.yt&&window.yt.config_||window.ytcfg&&window.ytcfg.data_||{};C("yt.config_",P);function Ec(a){var b=arguments;1<b.length?P[b[0]]=b[1]:1===b.length&&Object.assign(P,b[0])}
function Q(a,b){return a in P?P[a]:b}
;var Fc=[];function Gc(a){Fc.forEach(function(b){return b(a)})}
function Hc(a){return a&&window.yterr?function(){try{return a.apply(this,arguments)}catch(b){Ic(b),Gc(b)}}:a}
function Ic(a){var b=y("yt.logging.errors.log");b?b(a,"ERROR",void 0,void 0,void 0):(b=Q("ERRORS",[]),b.push([a,"ERROR",void 0,void 0,void 0]),Ec("ERRORS",b))}
function Jc(a){var b=y("yt.logging.errors.log");b?b(a,"WARNING",void 0,void 0,void 0):(b=Q("ERRORS",[]),b.push([a,"WARNING",void 0,void 0,void 0]),Ec("ERRORS",b))}
;var Kc=0;C("ytDomDomGetNextId",y("ytDomDomGetNextId")||function(){return++Kc});var Lc={stopImmediatePropagation:1,stopPropagation:1,preventMouseEvent:1,preventManipulation:1,preventDefault:1,layerX:1,layerY:1,screenX:1,screenY:1,scale:1,rotation:1,webkitMovementX:1,webkitMovementY:1};
function Mc(a){this.type="";this.state=this.source=this.data=this.currentTarget=this.relatedTarget=this.target=null;this.charCode=this.keyCode=0;this.metaKey=this.shiftKey=this.ctrlKey=this.altKey=!1;this.clientY=this.clientX=0;this.changedTouches=this.touches=null;try{if(a=a||window.event){this.event=a;for(var b in a)b in Lc||(this[b]=a[b]);var c=a.target||a.srcElement;c&&3==c.nodeType&&(c=c.parentNode);this.target=c;var d=a.relatedTarget;if(d)try{d=d.nodeName?d:null}catch(e){d=null}else"mouseover"==
this.type?d=a.fromElement:"mouseout"==this.type&&(d=a.toElement);this.relatedTarget=d;this.clientX=void 0!=a.clientX?a.clientX:a.pageX;this.clientY=void 0!=a.clientY?a.clientY:a.pageY;this.keyCode=a.keyCode?a.keyCode:a.which;this.charCode=a.charCode||("keypress"==this.type?this.keyCode:0);this.altKey=a.altKey;this.ctrlKey=a.ctrlKey;this.shiftKey=a.shiftKey;this.metaKey=a.metaKey}}catch(e){}}
Mc.prototype.preventDefault=function(){this.event&&(this.event.returnValue=!1,this.event.preventDefault&&this.event.preventDefault())};
Mc.prototype.stopPropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopPropagation&&this.event.stopPropagation())};
Mc.prototype.stopImmediatePropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopImmediatePropagation&&this.event.stopImmediatePropagation())};var F=y("ytEventsEventsListeners")||{};C("ytEventsEventsListeners",F);var Nc=y("ytEventsEventsCounter")||{count:0};C("ytEventsEventsCounter",Nc);
function Oc(a,b,c,d){d=void 0===d?{}:d;a.addEventListener&&("mouseenter"!=b||"onmouseenter"in document?"mouseleave"!=b||"onmouseenter"in document?"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"):b="mouseout":b="mouseover");return Ja(function(e){var f="boolean"===typeof e[4]&&e[4]==!!d,l=ua(e[4])&&ua(d)&&Ka(e[4],d);return!!e.length&&e[0]==a&&e[1]==b&&e[2]==c&&(f||l)})}
function Pc(a){a&&("string"==typeof a&&(a=[a]),E(a,function(b){if(b in F){var c=F[b],d=c[0],e=c[1],f=c[3];c=c[4];d.removeEventListener?Qc()||"boolean"===typeof c?d.removeEventListener(e,f,c):d.removeEventListener(e,f,!!c.capture):d.detachEvent&&d.detachEvent("on"+e,f);delete F[b]}}))}
var Qc=Ha(function(){var a=!1;try{var b=Object.defineProperty({},"capture",{get:function(){a=!0}});
window.addEventListener("test",null,b)}catch(c){}return a});
function Rc(a,b,c){var d=void 0===d?{}:d;if(a&&(a.addEventListener||a.attachEvent)){var e=Oc(a,b,c,d);if(!e){e=++Nc.count+"";var f=!("mouseenter"!=b&&"mouseleave"!=b||!a.addEventListener||"onmouseenter"in document);var l=f?function(g){g=new Mc(g);if(!xb(g.relatedTarget,function(h){return h==a}))return g.currentTarget=a,g.type=b,c.call(a,g)}:function(g){g=new Mc(g);
g.currentTarget=a;return c.call(a,g)};
l=Hc(l);a.addEventListener?("mouseenter"==b&&f?b="mouseover":"mouseleave"==b&&f?b="mouseout":"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"),Qc()||"boolean"===typeof d?a.addEventListener(b,l,d):a.addEventListener(b,l,!!d.capture)):a.attachEvent("on"+b,l);F[e]=[a,b,c,l,d]}}}
;function Sc(a,b){ta(a)&&(a=Hc(a));return window.setTimeout(a,b)}
function Tc(a){ta(a)&&(a=Hc(a));return window.setInterval(a,250)}
;function Uc(a){var b=[];Ia(a,function(c,d){var e=encodeURIComponent(String(d)),f;Array.isArray(c)?f=c:f=[c];E(f,function(l){""==l?b.push(e):b.push(e+"="+encodeURIComponent(String(l)))})});
return b.join("&")}
function Vc(a){"?"==a.charAt(0)&&(a=a.substr(1));a=a.split("&");for(var b={},c=0,d=a.length;c<d;c++){var e=a[c].split("=");if(1==e.length&&e[0]||2==e.length)try{var f=decodeURIComponent((e[0]||"").replace(/\+/g," ")),l=decodeURIComponent((e[1]||"").replace(/\+/g," "));f in b?Array.isArray(b[f])?Ga(b[f],l):b[f]=[b[f],l]:b[f]=l}catch(h){if("q"!=e[0]){var g=Error("Error decoding URL component");g.params={key:e[0],value:e[1]};Ic(g)}}}return b}
function Wc(a,b){return Xc(a,b||{},!0)}
function Xc(a,b,c){var d=a.split("#",2);a=d[0];d=1<d.length?"#"+d[1]:"";var e=a.split("?",2);a=e[0];e=Vc(e[1]||"");for(var f in b)!c&&null!==e&&f in e||(e[f]=b[f]);b=a;a=Bb(e);a?(c=b.indexOf("#"),0>c&&(c=b.length),f=b.indexOf("?"),0>f||f>c?(f=c,e=""):e=b.substring(f+1,c),b=[b.substr(0,f),e,b.substr(c)],c=b[1],b[1]=a?c?c+"&"+a:a:c,a=b[0]+(b[1]?"?"+b[1]:"")+b[2]):a=b;return a+d}
;var Yc={};function Zc(a){return Yc[a]||(Yc[a]=String(a).replace(/\-([a-z])/g,function(b,c){return c.toUpperCase()}))}
;var $c={},ad=[],pc=new M,bd={};function cd(){for(var a=t(ad),b=a.next();!b.done;b=a.next())b=b.value,b()}
function dd(a,b){b||(b=document);var c=Fa(b.getElementsByTagName("yt:"+a)),d="yt-"+a,e=b||document;d=Fa(e.querySelectorAll&&e.querySelector?e.querySelectorAll("."+d):vb(d,b));return Ea(c,d)}
function S(a,b){var c;"yt:"==a.tagName.toLowerCase().substr(0,3)?c=a.getAttribute(b):c=a?a.dataset?a.dataset[Zc(b)]:a.getAttribute("data-"+b):null;return c}
function ed(a,b){pc.I.apply(pc,arguments)}
;function fd(a){this.g=a||{};this.h=this.f=!1;a=document.getElementById("www-widgetapi-script");if(this.f=!!("https:"==document.location.protocol||a&&0==a.src.indexOf("https:"))){a=[this.g,window.YTConfig||{}];for(var b=0;b<a.length;b++)a[b].host&&(a[b].host=a[b].host.replace("http://","https://"))}}
function T(a,b){for(var c=[a.g,window.YTConfig||{}],d=0;d<c.length;d++){var e=c[d][b];if(void 0!=e)return e}return null}
function gd(a,b,c){hd||(hd={},Rc(window,"message",z(a.i,a)));hd[c]=b}
fd.prototype.i=function(a){if(a.origin==T(this,"host")||a.origin==T(this,"host").replace(/^http:/,"https:")){try{var b=JSON.parse(a.data)}catch(c){return}this.h=!0;this.f||0!=a.origin.indexOf("https:")||(this.f=!0);if(a=hd[b.id])a.A=!0,a.A&&(E(a.u,a.J,a),a.u.length=0),a.R(b)}};
var hd=null;function U(a){a=id(a);return"string"===typeof a&&"false"===a?!1:!!a}
function jd(a,b){var c=id(a);return void 0===c&&void 0!==b?b:Number(c||0)}
function id(a){var b=Q("EXPERIMENTS_FORCED_FLAGS",{});return void 0!==b[a]?b[a]:Q("EXPERIMENT_FLAGS",{})[a]}
;var kd=y("ytPubsubPubsubInstance")||new M;M.prototype.subscribe=M.prototype.subscribe;M.prototype.unsubscribeByKey=M.prototype.C;M.prototype.publish=M.prototype.I;M.prototype.clear=M.prototype.clear;C("ytPubsubPubsubInstance",kd);C("ytPubsubPubsubSubscribedKeys",y("ytPubsubPubsubSubscribedKeys")||{});C("ytPubsubPubsubTopicToKeys",y("ytPubsubPubsubTopicToKeys")||{});C("ytPubsubPubsubIsSynchronous",y("ytPubsubPubsubIsSynchronous")||{});var V=window,ld=V.ytcsi&&V.ytcsi.now?V.ytcsi.now:V.performance&&V.performance.timing&&V.performance.now&&V.performance.timing.navigationStart?function(){return V.performance.timing.navigationStart+V.performance.now()}:function(){return(new Date).getTime()};var md=jd("initial_gel_batch_timeout",1E3),nd=Math.pow(2,16)-1,od=null,pd=0,qd=void 0,rd=0,sd=0,td=0,ud=!0,vd=y("ytLoggingTransportLogPayloadsQueue_")||{};C("ytLoggingTransportLogPayloadsQueue_",vd);var wd=y("ytLoggingTransportGELQueue_")||new Map;C("ytLoggingTransportGELQueue_",wd);var xd=y("ytLoggingTransportTokensToCttTargetIds_")||{};C("ytLoggingTransportTokensToCttTargetIds_",xd);
function yd(){window.clearTimeout(rd);window.clearTimeout(sd);sd=0;qd&&qd.isReady()?(zd(wd),"log_event"in vd&&zd(Object.entries(vd.log_event)),wd.clear(),delete vd.log_event):Ad()}
function Ad(){U("web_gel_timeout_cap")&&!sd&&(sd=Sc(yd,6E4));window.clearTimeout(rd);var a=Q("LOGGING_BATCH_TIMEOUT",jd("web_gel_debounce_ms",1E4));U("shorten_initial_gel_batch_timeout")&&ud&&(a=md);rd=Sc(yd,a)}
function zd(a){var b=qd,c=Math.round(ld());a=t(a);for(var d=a.next();!d.done;d=a.next()){var e=t(d.value);d=e.next().value;var f=e.next().value;e=La({context:Bd(b.f||Cd())});e.events=f;(f=xd[d])&&Dd(e,d,f);delete xd[d];Ed(e,c);Fd(b,"log_event",e,{retry:!0,onSuccess:function(){pd=Math.round(ld()-c)}});
ud=!1}}
function Ed(a,b){a.requestTimeMs=String(b);U("unsplit_gel_payloads_in_logs")&&(a.unsplitGelPayloadsInLogs=!0);var c=Q("EVENT_ID",void 0);if(c){var d=Q("BATCH_CLIENT_COUNTER",void 0)||0;!d&&U("web_client_counter_random_seed")&&(d=Math.floor(Math.random()*nd/2));d++;d>nd&&(d=1);Ec("BATCH_CLIENT_COUNTER",d);c={serializedEventId:c,clientCounter:String(d)};a.serializedClientEventId=c;od&&pd&&U("log_gel_rtt_web")&&(a.previousBatchInfo={serializedClientEventId:od,roundtripMs:String(pd)});od=c;pd=0}}
function Dd(a,b,c){if(c.videoId)var d="VIDEO";else if(c.playlistId)d="PLAYLIST";else return;a.credentialTransferTokenTargetId=c;a.context=a.context||{};a.context.user=a.context.user||{};a.context.user.credentialTransferTokens=[{token:b,scope:d}]}
;function Gd(){}
function Hd(a){var b=5E3;isNaN(b)&&(b=void 0);var c=y("yt.scheduler.instance.addJob");c?c(a,0,b):void 0===b?a():Sc(a,b||0)}
;function W(){}
ma(W,Gd);W.prototype.start=function(){var a=y("yt.scheduler.instance.start");a&&a()};
W.f=void 0;W.g=function(){W.f||(W.f=new W)};
W.g();var Id=y("ytLoggingGelSequenceIdObj_")||{};C("ytLoggingGelSequenceIdObj_",Id);function Jd(a){var b=Kd;a=void 0===a?y("yt.ads.biscotti.lastId_")||"":a;b=Object.assign(Ld(b),Md(b));b.ca_type="image";a&&(b.bid=a);return b}
function Ld(a){var b={};b.dt=Jb;b.flash="0";a:{try{var c=a.f.top.location.href}catch(f){a=2;break a}a=c?c===a.g.location.href?0:1:2}b=(b.frm=a,b);b.u_tz=-(new Date).getTimezoneOffset();var d=void 0===d?H:d;try{var e=d.history.length}catch(f){e=0}b.u_his=e;b.u_java=!!H.navigator&&"unknown"!==typeof H.navigator.javaEnabled&&!!H.navigator.javaEnabled&&H.navigator.javaEnabled();H.screen&&(b.u_h=H.screen.height,b.u_w=H.screen.width,b.u_ah=H.screen.availHeight,b.u_aw=H.screen.availWidth,b.u_cd=H.screen.colorDepth);
H.navigator&&H.navigator.plugins&&(b.u_nplug=H.navigator.plugins.length);H.navigator&&H.navigator.mimeTypes&&(b.u_nmime=H.navigator.mimeTypes.length);return b}
function Md(a){var b=a.f;try{var c=b.screenX;var d=b.screenY}catch(n){}try{var e=b.outerWidth;var f=b.outerHeight}catch(n){}try{var l=b.innerWidth;var g=b.innerHeight}catch(n){}b=[b.screenLeft,b.screenTop,c,d,b.screen?b.screen.availWidth:void 0,b.screen?b.screen.availTop:void 0,e,f,l,g];c=a.f.top;try{var h=(c||window).document,k="CSS1Compat"==h.compatMode?h.documentElement:h.body;var m=(new ub(k.clientWidth,k.clientHeight)).round()}catch(n){m=new ub(-12245933,-12245933)}h=m;m={};k=new Pb;x.SVGElement&&
x.document.createElementNS&&k.set(0);c=Hb();c["allow-top-navigation-by-user-activation"]&&k.set(1);c["allow-popups-to-escape-sandbox"]&&k.set(2);x.crypto&&x.crypto.subtle&&k.set(3);x.TextDecoder&&x.TextEncoder&&k.set(4);k=Qb(k);m.bc=k;m.bih=h.height;m.biw=h.width;m.brdim=b.join();a=a.g;return m.vis={visible:1,hidden:2,prerender:3,preview:4,unloaded:5}[a.visibilityState||a.webkitVisibilityState||a.mozVisibilityState||""]||0,m.wgl=!!H.WebGLRenderingContext,m}
var Kd=new function(){var a=window.document;this.f=window;this.g=a};
C("yt.ads_.signals_.getAdSignalsString",function(a){return Uc(Jd(a))});B();var Nd=void 0!==XMLHttpRequest?function(){return new XMLHttpRequest}:void 0!==ActiveXObject?function(){return new ActiveXObject("Microsoft.XMLHTTP")}:null;
function Od(){if(!Nd)return null;var a=Nd();return"open"in a?a:null}
;var Pd={Authorization:"AUTHORIZATION","X-Goog-Visitor-Id":"SANDBOXED_VISITOR_ID","X-YouTube-Client-Name":"INNERTUBE_CONTEXT_CLIENT_NAME","X-YouTube-Client-Version":"INNERTUBE_CONTEXT_CLIENT_VERSION","X-YouTube-Device":"DEVICE","X-Youtube-Identity-Token":"ID_TOKEN","X-YouTube-Page-CL":"PAGE_CL","X-YouTube-Page-Label":"PAGE_BUILD_LABEL","X-YouTube-Variants-Checksum":"VARIANTS_CHECKSUM"},Qd="app debugcss debugjs expflag force_ad_params force_viral_ad_response_params forced_experiments innertube_snapshots innertube_goldens internalcountrycode internalipoverride absolute_experiments conditional_experiments sbb sr_bns_address".split(" "),
Rd=!1;
function Sd(a,b){b=void 0===b?{}:b;if(!c)var c=window.location.href;var d=I(a)[1]||null,e=J(I(a)[3]||null);d&&e?(d=c,c=I(a),d=I(d),c=c[3]==d[3]&&c[1]==d[1]&&c[4]==d[4]):c=e?J(I(c)[3]||null)==e&&(Number(I(c)[4]||null)||null)==(Number(I(a)[4]||null)||null):!0;d=U("web_ajax_ignore_global_headers_if_set");for(var f in Pd)e=Q(Pd[f]),!e||!c&&!Td(a,f)||d&&void 0!==b[f]||(b[f]=e);if(c||Td(a,"X-YouTube-Utc-Offset"))b["X-YouTube-Utc-Offset"]=String(-(new Date).getTimezoneOffset());(c||Td(a,"X-YouTube-Time-Zone"))&&(f=
"undefined"!=typeof Intl?(new Intl.DateTimeFormat).resolvedOptions().timeZone:null)&&(b["X-YouTube-Time-Zone"]=f);if(c||Td(a,"X-YouTube-Ad-Signals"))b["X-YouTube-Ad-Signals"]=Uc(Jd(void 0));return b}
function Ud(a){var b=window.location.search,c=J(I(a)[3]||null),d=J(I(a)[5]||null);d=(c=c&&(c.endsWith("youtube.com")||c.endsWith("youtube-nocookie.com")))&&d&&d.startsWith("/api/");if(!c||d)return a;var e=Vc(b),f={};E(Qd,function(l){e[l]&&(f[l]=e[l])});
return Xc(a,f||{},!1)}
function Td(a,b){var c=Q("CORS_HEADER_WHITELIST")||{},d=J(I(a)[3]||null);return d?(c=c[d])?0<=Ba(c,b):!1:!0}
function Vd(a,b){if(window.fetch&&"XML"!=b.format){var c={method:b.method||"GET",credentials:"same-origin"};b.headers&&(c.headers=b.headers);a=Wd(a,b);var d=Xd(a,b);d&&(c.body=d);b.withCredentials&&(c.credentials="include");var e=!1,f;fetch(a,c).then(function(l){if(!e){e=!0;f&&window.clearTimeout(f);var g=l.ok,h=function(k){k=k||{};var m=b.context||x;g?b.onSuccess&&b.onSuccess.call(m,k,l):b.onError&&b.onError.call(m,k,l);b.H&&b.H.call(m,k,l)};
"JSON"==(b.format||"JSON")&&(g||400<=l.status&&500>l.status)?l.json().then(h,function(){h(null)}):h(null)}});
b.da&&0<b.timeout&&(f=Sc(function(){e||(e=!0,window.clearTimeout(f))},b.timeout))}else Yd(a,b)}
function Yd(a,b){var c=b.format||"JSON";a=Wd(a,b);var d=Xd(a,b),e=!1,f,l=Zd(a,function(g){if(!e){e=!0;f&&window.clearTimeout(f);a:switch(g&&"status"in g?g.status:-1){case 200:case 201:case 202:case 203:case 204:case 205:case 206:case 304:var h=!0;break a;default:h=!1}var k=null,m=400<=g.status&&500>g.status,n=500<=g.status&&600>g.status;if(h||m||n)k=$d(c,g,b.sa);if(h)a:if(g&&204==g.status)h=!0;else{switch(c){case "XML":h=0==parseInt(k&&k.return_code,10);break a;case "RAW":h=!0;break a}h=!!k}k=k||
{};m=b.context||x;h?b.onSuccess&&b.onSuccess.call(m,g,k):b.onError&&b.onError.call(m,g,k);b.H&&b.H.call(m,g,k)}},b.method,d,b.headers,b.responseType,b.withCredentials);
b.N&&0<b.timeout&&(f=Sc(function(){e||(e=!0,l.abort(),window.clearTimeout(f))},b.timeout))}
function Wd(a,b){b.wa&&(a=document.location.protocol+"//"+document.location.hostname+(document.location.port?":"+document.location.port:"")+a);var c=Q("XSRF_FIELD_NAME",void 0),d=b.ea;d&&(d[c]&&delete d[c],a=Wc(a,d));return a}
function Xd(a,b){var c=Q("XSRF_FIELD_NAME",void 0),d=Q("XSRF_TOKEN",void 0),e=b.postBody||"",f=b.o,l=Q("XSRF_FIELD_NAME",void 0),g;b.headers&&(g=b.headers["Content-Type"]);b.va||J(I(a)[3]||null)&&!b.withCredentials&&J(I(a)[3]||null)!=document.location.hostname||"POST"!=b.method||g&&"application/x-www-form-urlencoded"!=g||b.o&&b.o[l]||(f||(f={}),f[c]=d);f&&"string"===typeof e&&(e=Vc(e),Na(e,f),e=b.P&&"JSON"==b.P?JSON.stringify(e):Bb(e));if(!(c=e)&&(c=f)){a:{for(var h in f){f=!1;break a}f=!0}c=!f}!Rd&&
c&&"POST"!=b.method&&(Rd=!0,Ic(Error("AJAX request with postData should use POST")));return e}
function $d(a,b,c){var d=null;switch(a){case "JSON":a=b.responseText;b=b.getResponseHeader("Content-Type")||"";a&&0<=b.indexOf("json")&&(d=JSON.parse(a));break;case "XML":if(b=(b=b.responseXML)?ae(b):null)d={},E(b.getElementsByTagName("*"),function(e){d[e.tagName]=be(e)})}c&&ce(d);
return d}
function ce(a){if(ua(a))for(var b in a){var c;(c="html_content"==b)||(c=b.length-5,c=0<=c&&b.indexOf("_html",c)==c);c?a[b]=new Za:ce(a[b])}}
function ae(a){return a?(a=("responseXML"in a?a.responseXML:a).getElementsByTagName("root"))&&0<a.length?a[0]:null:null}
function be(a){var b="";E(a.childNodes,function(c){b+=c.nodeValue});
return b}
function Zd(a,b,c,d,e,f,l){function g(){4==(h&&"readyState"in h?h.readyState:0)&&b&&Hc(b)(h)}
c=void 0===c?"GET":c;d=void 0===d?"":d;var h=Od();if(!h)return null;"onloadend"in h?h.addEventListener("loadend",g,!1):h.onreadystatechange=g;U("debug_forward_web_query_parameters")&&(a=Ud(a));h.open(c,a,!0);f&&(h.responseType=f);l&&(h.withCredentials=!0);c="POST"==c&&(void 0===window.FormData||!(d instanceof FormData));if(e=Sd(a,e))for(var k in e)h.setRequestHeader(k,e[k]),"content-type"==k.toLowerCase()&&(c=!1);c&&h.setRequestHeader("Content-Type","application/x-www-form-urlencoded");h.send(d);
return h}
;function de(){for(var a={},b=t(Object.entries(Vc(Q("DEVICE","")))),c=b.next();!c.done;c=b.next()){var d=t(c.value);c=d.next().value;d=d.next().value;"cbrand"===c?a.deviceMake=d:"cmodel"===c?a.deviceModel=d:"cbr"===c?a.browserName=d:"cbrver"===c?a.browserVersion=d:"cos"===c?a.osName=d:"cosver"===c?a.osVersion=d:"cplatform"===c&&(a.platform=d)}return a}
;function ee(){return"INNERTUBE_API_KEY"in P&&"INNERTUBE_API_VERSION"in P}
function Cd(){return{innertubeApiKey:Q("INNERTUBE_API_KEY",void 0),innertubeApiVersion:Q("INNERTUBE_API_VERSION",void 0),W:Q("INNERTUBE_CONTEXT_CLIENT_CONFIG_INFO"),X:Q("INNERTUBE_CONTEXT_CLIENT_NAME","WEB"),innertubeContextClientVersion:Q("INNERTUBE_CONTEXT_CLIENT_VERSION",void 0),Z:Q("INNERTUBE_CONTEXT_HL",void 0),Y:Q("INNERTUBE_CONTEXT_GL",void 0),aa:Q("INNERTUBE_HOST_OVERRIDE",void 0)||"",ba:!!Q("INNERTUBE_USE_THIRD_PARTY_AUTH",!1)}}
function Bd(a){a={client:{hl:a.Z,gl:a.Y,clientName:a.X,clientVersion:a.innertubeContextClientVersion,configInfo:a.W}};var b=window.devicePixelRatio;b&&1!=b&&(a.client.screenDensityFloat=String(b));b=Q("EXPERIMENTS_TOKEN","");""!==b&&(a.client.experimentsToken=b);b=[];var c=Q("EXPERIMENTS_FORCED_FLAGS",{});for(d in c)b.push({key:d,value:String(c[d])});var d=Q("EXPERIMENT_FLAGS",{});for(var e in d)e.startsWith("force_")&&void 0===c[e]&&b.push({key:e,value:String(d[e])});0<b.length&&(a.request={internalExperimentFlags:b});
Q("DELEGATED_SESSION_ID")&&!U("pageid_as_header_web")&&(a.user={onBehalfOfUser:Q("DELEGATED_SESSION_ID")});a.client=Object.assign(a.client,de());return a}
function fe(a,b,c){c=void 0===c?{}:c;var d={"X-Goog-Visitor-Id":c.visitorData||Q("VISITOR_DATA","")};if(b&&b.includes("www.youtube-nocookie.com"))return d;(b=c.ra||Q("AUTHORIZATION"))||(a?b="Bearer "+y("gapi.auth.getToken")().qa:b=Ob([]));b&&(d.Authorization=b,d["X-Goog-AuthUser"]=Q("SESSION_INDEX",0),U("pageid_as_header_web")&&(d["X-Goog-PageId"]=Q("DELEGATED_SESSION_ID")));return d}
function ge(a){a=Object.assign({},a);delete a.Authorization;var b=Ob();if(b){var c=new ec;c.update(Q("INNERTUBE_API_KEY",void 0));c.update(b);b=c.digest();c=3;void 0===c&&(c=0);if(!pb){pb={};for(var d="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".split(""),e=["+/=","+/","-_=","-_.","-_"],f=0;5>f;f++){var l=d.concat(e[f].split(""));ob[f]=l;for(var g=0;g<l.length;g++){var h=l[g];void 0===pb[h]&&(pb[h]=g)}}}c=ob[c];d=[];for(e=0;e<b.length;e+=3){var k=b[e],m=(f=e+1<b.length)?b[e+1]:
0;h=(l=e+2<b.length)?b[e+2]:0;g=k>>2;k=(k&3)<<4|m>>4;m=(m&15)<<2|h>>6;h&=63;l||(h=64,f||(m=64));d.push(c[g],c[k],c[m]||"",c[h]||"")}a.hash=d.join("")}return a}
;function he(){var a=new xc;(a=a.isAvailable()?new Dc(a,"yt.innertube"):null)||(a=new yc("yt.innertube"),a=a.isAvailable()?a:null);this.f=a?new O(a):null;this.g=document.domain||window.location.hostname}
he.prototype.set=function(a,b,c,d){c=c||31104E3;this.remove(a);if(this.f)try{this.f.set(a,b,B()+1E3*c);return}catch(f){}var e="";if(d)try{e=escape(nc(b))}catch(f){return}else e=escape(b);b=this.g;tb.set(""+a,e,{L:c,path:"/",domain:void 0===b?"youtube.com":b,secure:!1})};
he.prototype.get=function(a,b){var c=void 0,d=!this.f;if(!d)try{c=this.f.get(a)}catch(e){d=!0}if(d&&(c=tb.get(""+a,void 0))&&(c=unescape(c),b))try{c=JSON.parse(c)}catch(e){this.remove(a),c=void 0}return c};
he.prototype.remove=function(a){this.f&&this.f.remove(a);var b=this.g;tb.remove(""+a,"/",void 0===b?"youtube.com":b)};var X=new he;function ie(a,b,c,d){if(d)return null;d=X.get("nextId",!0)||1;var e=X.get("requests",!0)||{};e[d]={method:a,request:b,authState:ge(c),requestTime:Math.round(ld())};X.set("nextId",d+1,86400,!0);X.set("requests",e,86400,!0);return d}
function je(a){var b=X.get("requests",!0)||{};delete b[a];X.set("requests",b,86400,!0)}
function ke(a){var b=X.get("requests",!0);if(b){for(var c in b){var d=b[c];if(!(6E4>Math.round(ld())-d.requestTime)){var e=d.authState,f=ge(fe(!1));Ka(e,f)&&(e=d.request,"requestTimeMs"in e&&(e.requestTimeMs=Math.round(ld())),Fd(a,d.method,e,{}));delete b[c]}}X.set("requests",b,86400,!0)}}
;function le(a){var b=this;this.f=null;a?this.f=a:ee()&&(this.f=Cd());Hd(function(){ke(b)})}
le.prototype.isReady=function(){!this.f&&ee()&&(this.f=Cd());return!!this.f};
function Fd(a,b,c,d){!Q("VISITOR_DATA")&&"visitor_id"!==b&&.01>Math.random()&&Jc(Error("Missing VISITOR_DATA when sending innertube request."));var e={headers:{"Content-Type":"application/json"},method:"POST",o:c,P:"JSON",N:function(){},
da:d.N,onSuccess:function(q,p){if(d.onSuccess)d.onSuccess(p)},
M:function(q){if(d.onSuccess)d.onSuccess(q)},
onError:function(q,p){if(d.onError)d.onError(p)},
xa:function(q){if(d.onError)d.onError(q)},
timeout:d.timeout,withCredentials:!0},f="",l=a.f.aa;l&&(f=l);l=a.f.ba||!1;var g=fe(l,f,d);Object.assign(e.headers,g);e.headers.Authorization&&!f&&(e.headers["x-origin"]=window.location.origin);var h=Wc(""+f+("/youtubei/"+a.f.innertubeApiVersion+"/"+b),{alt:"json",key:a.f.innertubeApiKey}),k;if(d.retry&&U("retry_web_logging_batches")&&"www.youtube-nocookie.com"!=f&&(k=ie(b,c,g,l))){var m=e.onSuccess,n=e.M;e.onSuccess=function(q,p){je(k);m(q,p)};
c.M=function(q,p){je(k);n(q,p)}}try{U("use_fetch_for_op_xhr")?Vd(h,e):(e.method="POST",e.o||(e.o={}),Yd(h,e))}catch(q){if("InvalidAccessError"==q)k&&(je(k),k=0),Jc(Error("An extension is blocking network request."));
else throw q;}k&&Hd(function(){ke(a)})}
;var me=new Set,ne=0;function oe(a,b,c,d){c+="."+a;a=String(JSON.stringify(b)).substr(0,500);d[c]=a;return c.length+a.length}
;function Y(a,b,c){this.m=this.f=this.g=null;this.l=va(this);this.h=0;this.A=!1;this.u=[];this.i=null;this.S=c;this.U={};c=document;if(a="string"===typeof a?c.getElementById(a):a)if(c="iframe"==a.tagName.toLowerCase(),b.host||(b.host=c?zb(a.src):"https://www.youtube.com"),this.g=new fd(b),c||(b=pe(this,a),this.m=a,(c=a.parentNode)&&c.replaceChild(b,a),a=b),this.f=a,this.f.id||(this.f.id="widget"+va(this.f)),$c[this.f.id]=this,window.postMessage){this.i=new M;qe(this);b=T(this.g,"events");for(var d in b)b.hasOwnProperty(d)&&
this.addEventListener(d,b[d]);for(var e in bd)re(this,e)}}
r=Y.prototype;r.setSize=function(a,b){this.f.width=a;this.f.height=b;return this};
r.ca=function(){return this.f};
r.R=function(a){this.B(a.event,a)};
r.addEventListener=function(a,b){var c=b;"string"==typeof b&&(c=function(){window[b].apply(window,arguments)});
if(!c)return this;this.i.subscribe(a,c);se(this,a);return this};
function re(a,b){var c=b.split(".");if(2==c.length){var d=c[1];a.S==c[0]&&se(a,d)}}
r.destroy=function(){this.f.id&&($c[this.f.id]=null);var a=this.i;a&&"function"==typeof a.dispose&&a.dispose();if(this.m){a=this.f;var b=a.parentNode;b&&b.replaceChild(this.m,a)}else(a=this.f)&&a.parentNode&&a.parentNode.removeChild(a);hd&&(hd[this.l]=null);this.g=null;a=this.f;for(var c in F)F[c][0]==a&&Pc(c);this.m=this.f=null};
r.D=function(){return{}};
function te(a,b,c){c=c||[];c=Array.prototype.slice.call(c);b={event:"command",func:b,args:c};a.A?a.J(b):a.u.push(b)}
r.B=function(a,b){if(!this.i.h){var c={target:this,data:b};this.i.I(a,c);ed(this.S+"."+a,c)}};
function pe(a,b){for(var c=document.createElement("iframe"),d=b.attributes,e=0,f=d.length;e<f;e++){var l=d[e].value;null!=l&&""!=l&&"null"!=l&&c.setAttribute(d[e].name,l)}c.setAttribute("frameBorder",0);c.setAttribute("allowfullscreen",1);c.setAttribute("allow","accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture");c.setAttribute("title","YouTube "+T(a.g,"title"));(d=T(a.g,"width"))&&c.setAttribute("width",d);(d=T(a.g,"height"))&&c.setAttribute("height",d);var g=a.D();g.enablejsapi=
window.postMessage?1:0;window.location.host&&(g.origin=window.location.protocol+"//"+window.location.host);g.widgetid=a.l;window.location.href&&E(["debugjs","debugcss"],function(h){var k=window.location.href;var m=k.search(Cb);b:{var n=0;for(var q=h.length;0<=(n=k.indexOf(h,n))&&n<m;){var p=k.charCodeAt(n-1);if(38==p||63==p)if(p=k.charCodeAt(n+q),!p||61==p||38==p||35==p)break b;n+=q+1}n=-1}if(0>n)k=null;else{q=k.indexOf("&",n);if(0>q||q>m)q=m;n+=h.length+1;k=decodeURIComponent(k.substr(n,q-n).replace(/\+/g,
" "))}null!==k&&(g[h]=k)});
c.src=T(a.g,"host")+a.F()+"?"+Bb(g);return c}
r.O=function(){this.f&&this.f.contentWindow?this.J({event:"listening"}):window.clearInterval(this.h)};
function qe(a){gd(a.g,a,a.l);a.h=Tc(z(a.O,a));Rc(a.f,"load",z(function(){window.clearInterval(this.h);this.h=Tc(z(this.O,this))},a))}
function se(a,b){a.U[b]||(a.U[b]=!0,te(a,"addEventListener",[b]))}
r.J=function(a){a.id=this.l;a.channel="widget";a=nc(a);var b=this.g;var c=zb(this.f.src||"");b=0==c.indexOf("https:")?[c]:b.f?[c.replace("http:","https:")]:b.h?[c]:[c,c.replace("http:","https:")];if(this.f.contentWindow)for(c=0;c<b.length;c++)try{this.f.contentWindow.postMessage(a,b[c])}catch(A){if(A.name&&"SyntaxError"==A.name){if(!(A.message&&0<A.message.indexOf("target origin ''"))){var d=void 0,e=void 0,f=A;e=void 0===e?{}:e;e.name=Q("INNERTUBE_CONTEXT_CLIENT_NAME",1);e.version=Q("INNERTUBE_CONTEXT_CLIENT_VERSION",
void 0);var l=e||{};e="WARNING";e=void 0===e?"ERROR":e;var g=window&&window.yterr||!1;if(f&&g&&!(5<=ne)){if(U("console_log_js_exceptions")){g=f;var h=[];h.push("Name: "+g.name);h.push("Message: "+g.message);g.hasOwnProperty("params")&&h.push("Error Params: "+JSON.stringify(g.params));h.push("File name: "+g.fileName);h.push("Stacktrace: "+g.stack);window.console.log(h.join("\n"),g)}if(0!==f.f){g=f.g;h=f.columnNumber;if(f.args&&f.args.length){var k=0;for(d=0;d<f.args.length;d++){var m=f.args[d],n="params."+
d;k+=n.length;if(m)if(Array.isArray(m)){var q=m;m=n;n=l;for(var p=0;p<q.length&&!(q[p]&&(k+=oe(p,q[p],m,n),500<k));p++);}else if("object"===typeof m)for(q in q=void 0,p=l,m){if(m[q]&&(k+=oe(q,m[q],n,p),500<k))break}else l[n]=String(JSON.stringify(m)).substring(0,500),k+=l[n].length;else l[n]=String(JSON.stringify(m)).substring(0,500),k+=l[n].length;if(500<=k)break}}else if(f.hasOwnProperty("params"))if(k=f.params,"object"===typeof f.params)for(d in q=0,k){if(k[d]&&(m="params."+d,n=String(JSON.stringify(k[d])).substr(0,
500),l[m]=n,q+=m.length+n.length,500<q))break}else l.params=String(JSON.stringify(k)).substr(0,500);f=qb(f);(g=g||f.stack)||(g="Not available");k={stackTrace:g};f.fileName&&(k.filename=f.fileName);d=f.lineNumber.toString();isNaN(d)||!h||isNaN(h)||(k.lineNumber=Number(d),k.columnNumber=Number(h),d=d+":"+h);window.yterr&&ta(window.yterr)&&(f.params=l,window.yterr(f));if(!(me.has(f.message)||0<=g.indexOf("/YouTubeCenter.js")||0<=g.indexOf("/mytube.js"))){if(U("kevlar_gel_error_routing")){h=void 0;m=
e;n=k;k=l;q={level:"ERROR_LEVEL_UNKNOWN",message:f.message};"ERROR"===m?q.level="ERROR_LEVEL_ERROR":"WARNING"===m&&(q.level="ERROR_LEVEL_WARNNING");m={isObfuscated:!0,browserStackInfo:n};n={pageUrl:window.location.href,kvPairs:[]};p=t(Object.keys(k));for(var w=p.next();!w.done;w=p.next())w=w.value,n.kvPairs.push({key:"client."+w,value:String(k[w])});m={errorMetadata:n,stackTrace:m,logMessage:q};h=void 0===h?{}:h;k=le;Q("ytLoggingEventsDefaultDisabled",!1)&&le==le&&(k=null);h=void 0===h?{}:h;q={};
q.eventTimeMs=Math.round(h.timestamp||ld());q.clientError=m;m=String;h.timestamp?n=-1:(n=y("_lact",window),null==n?n=-1:n=Math.max(B()-n,0));q.context={lastActivityMs:m(n)};U("log_sequence_info_on_gel_web")&&h.T&&(m=q.context,n=h.T,Id[n]=n in Id?Id[n]+1:0,m.sequence={index:Id[n],groupKey:n},h.ua&&delete Id[h.T]);h=h.ta;m="";h&&(m=h,n={},m.videoId?n.videoId=m.videoId:m.playlistId&&(n.playlistId=m.playlistId),xd[h.token]=n,m=h.token);h=wd.get(m)||[];wd.set(m,h);h.push(q);k&&(qd=new k);k=jd("web_logging_max_batch")||
100;q=ld();h.length>=k?yd():10<=q-td&&(Ad(),td=q);yd()}e={ea:{a:"logerror",t:"jserror",type:f.name,msg:f.message.substr(0,250),line:d,level:e,"client.name":l.name},o:{url:Q("PAGE_NAME",window.location.href),file:f.fileName},method:"POST"};l.version&&(e["client.version"]=l.version);if(e.o){g&&(e.o.stack=g);g=t(Object.keys(l));for(d=g.next();!d.done;d=g.next())d=d.value,e.o["client."+d]=l[d];if(l=Q("LATEST_ECATCHER_SERVICE_TRACKING_PARAMS",void 0))for(g=t(Object.keys(l)),d=g.next();!d.done;d=g.next())d=
d.value,e.o[d]=l[d];l=Q("SERVER_NAME",void 0);g=Q("SERVER_VERSION",void 0);l&&g&&(e.o["server.name"]=l,e.o["server.version"]=g)}Yd(Q("ECATCHER_REPORT_HOST","")+"/error_204",e);me.add(f.message);ne++}}}}}else throw A;}else console&&console.warn&&console.warn("The YouTube player is not attached to the DOM. API calls should be made after the onReady event. See more: https://developers.google.com/youtube/iframe_api_reference#Events")};function ue(a){return(0===a.search("cue")||0===a.search("load"))&&"loadModule"!==a}
function ve(a){return 0===a.search("get")||0===a.search("is")}
;function Z(a,b){if(!a)throw Error("YouTube player element ID required.");var c={title:"video player",videoId:"",width:640,height:360};if(b)for(var d in b)c[d]=b[d];Y.call(this,a,c,"player");this.v={};this.playerInfo={}}
ma(Z,Y);r=Z.prototype;r.F=function(){return"/embed/"+T(this.g,"videoId")};
r.D=function(){var a=T(this.g,"playerVars");if(a){var b={},c;for(c in a)b[c]=a[c];a=b}else a={};window!=window.top&&document.referrer&&(a.widget_referrer=document.referrer.substring(0,256));if(c=T(this.g,"embedConfig")){if(ua(c))try{c=JSON.stringify(c)}catch(d){console.error("Invalid embed config JSON",d)}a.embed_config=c}return a};
r.R=function(a){var b=a.event;a=a.info;switch(b){case "apiInfoDelivery":if(ua(a))for(var c in a)this.v[c]=a[c];break;case "infoDelivery":we(this,a);break;case "initialDelivery":window.clearInterval(this.h);this.playerInfo={};this.v={};xe(this,a.apiInterface);we(this,a);break;default:this.B(b,a)}};
function we(a,b){if(ua(b))for(var c in b)a.playerInfo[c]=b[c]}
function xe(a,b){E(b,function(c){this[c]||("getCurrentTime"==c?this[c]=function(){var d=this.playerInfo.currentTime;if(1==this.playerInfo.playerState){var e=(B()/1E3-this.playerInfo.currentTimeLastUpdated_)*this.playerInfo.playbackRate;0<e&&(d+=Math.min(e,1))}return d}:ue(c)?this[c]=function(){this.playerInfo={};
this.v={};te(this,c,arguments);return this}:ve(c)?this[c]=function(){var d=0;
0===c.search("get")?d=3:0===c.search("is")&&(d=2);return this.playerInfo[c.charAt(d).toLowerCase()+c.substr(d+1)]}:this[c]=function(){te(this,c,arguments);
return this})},a)}
r.getVideoEmbedCode=function(){var a=parseInt(T(this.g,"width"),10),b=parseInt(T(this.g,"height"),10),c=T(this.g,"host")+this.F();Va.test(c)&&(-1!=c.indexOf("&")&&(c=c.replace(Pa,"&amp;")),-1!=c.indexOf("<")&&(c=c.replace(Qa,"&lt;")),-1!=c.indexOf(">")&&(c=c.replace(Ra,"&gt;")),-1!=c.indexOf('"')&&(c=c.replace(Sa,"&quot;")),-1!=c.indexOf("'")&&(c=c.replace(Ta,"&#39;")),-1!=c.indexOf("\x00")&&(c=c.replace(Ua,"&#0;")));return'<iframe width="'+a+'" height="'+b+'" src="'+c+'" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>'};
r.getOptions=function(a){return this.v.namespaces?a?this.v[a].options||[]:this.v.namespaces||[]:[]};
r.getOption=function(a,b){if(this.v.namespaces&&a&&b)return this.v[a][b]};
function ye(a){if("iframe"!=a.tagName.toLowerCase()){var b=S(a,"videoid");b&&(b={videoId:b,width:S(a,"width"),height:S(a,"height")},new Z(a,b))}}
;function ze(a,b){var c={title:"Thumbnail",videoId:"",width:120,height:68};if(b)for(var d in b)c[d]=b[d];Y.call(this,a,c,"thumbnail")}
ma(ze,Y);ze.prototype.F=function(){return"/embed/"+T(this.g,"videoId")};
ze.prototype.D=function(){return{player:0,thumb_width:T(this.g,"thumbWidth"),thumb_height:T(this.g,"thumbHeight"),thumb_align:T(this.g,"thumbAlign")}};
ze.prototype.B=function(a,b){Y.prototype.B.call(this,a,b?b.info:void 0)};
function Ae(a){if("iframe"!=a.tagName.toLowerCase()){var b=S(a,"videoid");if(b){b={videoId:b,events:{},width:S(a,"width"),height:S(a,"height"),thumbWidth:S(a,"thumb-width"),thumbHeight:S(a,"thumb-height"),thumbAlign:S(a,"thumb-align")};var c=S(a,"onclick");c&&(b.events.onClick=c);new ze(a,b)}}}
;C("YT.PlayerState.UNSTARTED",-1);C("YT.PlayerState.ENDED",0);C("YT.PlayerState.PLAYING",1);C("YT.PlayerState.PAUSED",2);C("YT.PlayerState.BUFFERING",3);C("YT.PlayerState.CUED",5);C("YT.get",function(a){return $c[a]});
C("YT.scan",cd);C("YT.subscribe",function(a,b,c){pc.subscribe(a,b,c);bd[a]=!0;for(var d in $c)re($c[d],a)});
C("YT.unsubscribe",function(a,b,c){oc(a,b,c)});
C("YT.Player",Z);C("YT.Thumbnail",ze);Y.prototype.destroy=Y.prototype.destroy;Y.prototype.setSize=Y.prototype.setSize;Y.prototype.getIframe=Y.prototype.ca;Y.prototype.addEventListener=Y.prototype.addEventListener;Z.prototype.getVideoEmbedCode=Z.prototype.getVideoEmbedCode;Z.prototype.getOptions=Z.prototype.getOptions;Z.prototype.getOption=Z.prototype.getOption;ad.push(function(a){a=dd("player",a);E(a,ye)});
ad.push(function(){var a=dd("thumbnail");E(a,Ae)});
"undefined"!=typeof YTConfig&&YTConfig.parsetags&&"onload"!=YTConfig.parsetags||cd();var Be=y("onYTReady");Be&&Be();var Ce=y("onYouTubeIframeAPIReady");Ce&&Ce();var De=y("onYouTubePlayerAPIReady");De&&De();}).call(this);
