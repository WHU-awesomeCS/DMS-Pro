/** layuiAdmin.pro-v1.2.1 LPPL License By http://www.layui.com/admin/ */
 ;layui.define(["jquery","laytpl","layer"],function(e){"use strict";layui.link("/layuiadmin/css/autocomplete.css");var hint=layui.hint(),$=layui.jquery,laytpl=layui.laytpl,layer=layui.layer,module="autocomplete",filter="layui-autocomplete",container="layui-form-autocomplete",container_focus="layui-form-autocomplete-focus",system={config:{template:['<div class="layui-form-autocomplete">','<dl class="layui-anim layui-anim-upbit">',"</dl>","</div>"].join(""),layout:['<dd data-index="{{d.index}}">{{d.text}}</dd>'].join(""),template_txt:"{{d.text}}",template_val:"{{d.value}}",cache:!1},index:layui.autocomplete?layui.autocomplete.index+1e4:0,data:{}},callback=function(){var e=this,t=e.config,n=t.id;return n&&(callback.config[n]=t),{config:e.config}},job=function(e){var t=this;t.index=++system.index,t.config=$.extend({},t.config,system.config,e),t.render()};job.prototype.config={text:{none:"无数据",loading:"加载中"},response:{code:"Code",data:"Data"},ajax:[],data:[],filter:""},job.prototype.render=function(){var e=this,t=e.config;if(t.elem=$(t.elem),t.where=t.where||{},!t.elem[0])return e;var n=t.elem,a=n.next("."+container),o=e.elem=$(laytpl(t.template).render({}));t.id=e.id,a[0]&&a.remove(),n.attr("autocomplete","off"),n.after(o),e.events()},job.prototype.pullData=function(){var _self=this,_config=_self.config,_elem=_config.elem,_container=_elem.next("."+container),_dom=_container.find("dl");return _config.filter?_config.cache&&_config.data[_self.index]?_self.renderData(_config.data[_self.index]):void(_config.cache&&void 0!=_config.ajax[_self.index]||(!_config.cache&&void 0!=_config.ajax[_self.index]&&_config.ajax[_self.index].abort(),_config.ajax[_self.index]=$.ajax({type:_config.method||"get",url:_config.url,data:{keywords:_config.filter},dataType:"json",beforeSend:function(){_container.addClass(container_focus),_dom.html(['<dd style="text-align: center" autocomplete-load>',_config.text.loading,"</dd>"].join(""))},success:function(resp){return 200!=eval("resp."+_config.response.code)?layer.msg(eval("resp."+_config.response.data)):_config.data[_self.index]=eval("resp."+_config.response.data),_self.renderData(_config.data[_self.index])},error:function(e,t,n){},complete:function(){delete _config.ajax[_self.index]}}))):_self.renderData([])},job.prototype.renderData=function(e){var t=this,n=t.config,a=n.elem,o=a.next("."+container),i=o.find("dl"),l=[];layui.each(e,function(e,t){console.log(t),"object"==typeof t||"array"==typeof t?$.each(t,function(a,o){try{return l.push(laytpl(n.layout).render({index:e,text:laytpl(n.template_txt).render(t)})),!1}catch(i){}}):l.push(laytpl(n.layout).render({index:e,text:laytpl(n.template_txt).render(t)}))}),console.log(l),i.html(l.join("")),l.length>0?o.addClass(container_focus):o.removeClass(container_focus)},job.prototype.events=function(){var e=this,t=e.config,n=t.elem,a=n.next("."+container),o=a.find("dl");n.on("focus",function(){t.filter=this.value,t.cache?e.pullData():e.renderData(t.data[e.index])}).on("input propertychange",function(){t.filter=this.value,e.pullData()}),$(document).on("click",function(i){var l=i.target,c=o.find(l),r=c.length>0?c.closest("dd"):void 0;if(l===n[0])return!1;if(void 0!==r){if(void 0!==r.attr("autocomplete-load"))return!1;n.val(laytpl(t.template_val).render(t.data[e.index][r.index()])),void 0==t.onselect||t.onselect(t.data[e.index][r.index()])}a.removeClass(container_focus)})},callback.config={},callback.job={},system.init=function(e,t){var t=t||{},n=$(e?'input[lay-filter="'+e+'"]':"input["+filter+"]");n.each(function(e,n){var a=$(n),o=a.attr("lay-data");try{o=new Function("return "+o)()}catch(i){return hint.error("autocomplete元素属性lay-data配置项存在语法错误："+o)}var l=$.extend({elem:this},system.config,t,o);void 0==l.url&&(void 0==l.data||0===l.length)&&hint.error("autocomplete配置有误，缺少获取数据方式"),system.render(l)})},system.render=function(e){var t=new job(e);return callback.call(t)},system.init(),e(module,system)});