:setvar path "C:\Users\bbdnet2055\Documents\GRADPROGRAM2022\Project-DIY\Diy-Project\Scripts" -- change to your own path
GO
:r $(path)\Tables\createUsersScript.sql.sql
:r $(path)\Tables\createContactDetailsScript.sql.sql
:r $(path)\Tables\createServiceProvidersScript.sql.sql

:r $(path)\Tables\ForeignKeys.sql

GO

-- :r $(path)"\User Defined Function\udfCakePrice.sql"
-- :r $(path)"\User Defined Function\udfOrderPrice.sql"
-- :r $(path)"\User Defined Function\CalculateOrderPrices.sql"

-- GO

-- :r $(path)"\Stored Procedures\AddNewToppingProc.sql"
-- :r $(path)"\Stored Procedures\GetCartItems.sql"     


-- GO

-- :r $(path)\Data\BaseData.sql
-- :r $(path)\Data\ShapeData.sql
-- :r $(path)\Data\StatusData.sql
-- :r $(path)\Data\ToppingData.sql
-- :r $(path)\Data\IcingData.sql
-- :r $(path)\Data\CakeData.sql
-- :r $(path)\Data\LocationData.sql
-- :r $(path)\Data\CustomerData.sql
-- :r $(path)\Data\OrderData.sql
-- :r $(path)\Data\DeliveryData.sql
-- :r $(path)\Data\CartOrder.sql


-- :r $(path)"\Stored Procedures\OrderPriceUpdate.sql"

-- GO

-- :r $(path)\Views\CustomerCakes.sql
-- :r $(path)\Views\CakeCombos.sql

-- GO
