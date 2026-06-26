# Trade UI Test Report

[PASS] EnsureSceneOwnedUIPanels executes successfully
[PASS] TradePanel exists in TownScene
[PASS] TradeOpenButton exists under BottomActionBar
[PASS] TradePanelView component is attached to TradePanel
[PASS] Header exists under TradePanel
[PASS] StatusSection exists under TradePanel
[PASS] InventorySection exists under TradePanel
[PASS] OffersSection exists under TradePanel
[PASS] Footer exists under TradePanel
[PASS] TitleText says MERCHANT TRADE
[PASS] CloseButton exists in Header
[PASS] RefreshButton exists in Footer
[PASS] txtMerchantStatus is wired
[PASS] txtDaysUntilNextMerchant is wired
[PASS] txtWood is wired
[PASS] txtFood is wired
[PASS] txtIron is wired
[PASS] txtCoal is wired
[PASS] txtSteel is wired
[PASS] btnOfferWoodToIron is wired
[PASS] btnOfferFoodToWood is wired
[PASS] btnOfferIronToSteel is wired
[PASS] btnOfferWoodToCoal is wired
[PASS] TradePanel is hidden by default
[PASS] OpenTradePanel sets TradePanel active
[PASS] CloseTradePanel sets TradePanel inactive
[PASS] Merchant status text indicates absent
[PASS] Merchant countdown indicates 2 days
[PASS] Wood -> Iron offer button is disabled when merchant absent
[PASS] Food -> Wood offer button is disabled when merchant absent
[PASS] Iron -> Steel offer button is disabled when merchant absent
[PASS] Wood -> Coal offer button is disabled when merchant absent
[PASS] Result text shows merchant absent status
[PASS] Merchant status text indicates present
[PASS] Merchant countdown indicates remaining duration
[PASS] Wood -> Iron offer button is enabled when resources allow
[PASS] Valid trade succeeds and decreases Wood
[PASS] Valid trade succeeds and increases Iron
[PASS] ResultText shows success log message
[PASS] Inventory Wood text updates on screen
[PASS] Inventory Iron text updates on screen
[PASS] Second trade succeeds and decreases Wood to 20
[PASS] Second trade succeeds and increases Iron to 20
[PASS] Wood -> Iron button becomes disabled when Wood is insufficient
[PASS] Execute command with insufficient resources returns failure
[PASS] Execute command leaves resources unchanged
[PASS] Wood -> Iron button is disabled when buy resource capacity exceeded
[PASS] SelectedVillagerPanel exists
[PASS] OptionsScrollArea exists under SelectedVillagerPanel
[PASS] BlacksmithCraftPanel exists
[PASS] BuildMenuPanel exists
[PASS] WorldMapPanel exists
[PASS] ExpeditionResultPanel exists
[PASS] MainCanvasSetupTool.cs is absent
[PASS] ForceRunSetup.cs is absent
[PASS] MainCanvas.prefab is absent

Total PASS: 56
Total FAIL: 0
