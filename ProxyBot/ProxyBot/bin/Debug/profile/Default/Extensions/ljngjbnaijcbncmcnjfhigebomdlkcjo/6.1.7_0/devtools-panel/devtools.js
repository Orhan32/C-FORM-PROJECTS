var _0x39a1=['panels','tabId','inspectedWindow','createSidebarPane','generate-selector','extension','../devtools-panel/devtools-content.html','sendMessage','setPage','onHidden','xpath','postMessage','runtime','devtools-page','ChroPath'];(function(_0x18eeb5,_0x39a1a2){var _0x335342=function(_0x1303d9){while(--_0x1303d9){_0x18eeb5['push'](_0x18eeb5['shift']());}};_0x335342(++_0x39a1a2);}(_0x39a1,0xcc));var _0x3353=function(_0x18eeb5,_0x39a1a2){_0x18eeb5=_0x18eeb5-0x0;var _0x335342=_0x39a1[_0x18eeb5];return _0x335342;};var backgroundPageConnection=chrome[_0x3353('0x3')]['connect']({'name':_0x3353('0x4')});chrome['devtools'][_0x3353('0x6')]['elements'][_0x3353('0x9')](_0x3353('0x5'),function(_0x37e060){_0x37e060[_0x3353('0xe')](_0x3353('0xc'));_0x37e060['onShown']['addListener'](handleShown);_0x37e060[_0x3353('0x0')]['addListener'](handleHidden);});function handleShown(){chrome[_0x3353('0xb')][_0x3353('0xd')]({'message':_0x3353('0xa')});}function handleHidden(){var _0x71fcf2=_0x3353('0x1');var _0x55f5d2=![];var _0x14374d=[_0x71fcf2,'',_0x55f5d2];backgroundPageConnection[_0x3353('0x2')]({'name':'highlight-element','tabId':chrome['devtools'][_0x3353('0x8')][_0x3353('0x7')],'xpath':_0x14374d});}