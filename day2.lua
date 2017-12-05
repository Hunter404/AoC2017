-- Optimizations
local tinsert = table.insert
local mmin = math.min
local mmax = math.max

local module = {}

--- Split string by string
-- @tparam string to split
-- @tparam string to split by
-- @treturn table the result of the split
local function split(str, m)
  local out = {}
  for k, v in string.gmatch(str, "[^" .. m .. "]+") do
    insert(out, k)
  end

  return out
end

--- Calculate checksum of spreadsheet
-- @tparam table spreadsheet
-- @treturn number checksum
function module:spreadSheetChecksum (spreadsheet)
  local sum = 0

  for k, row in pairs(split(hash, "\n\r")) do
    local min, max
  
    for k, col in pairs(split(row, "\t")) do
      local num = tonumber(col)
      print(num)
      if not min then
        min = num
      else
        min = mmin(num, min)
      end
      
      if not max then
        max = num
      else
        max = mmax(num, max)
      end
    end
    
    sum = sum + max - min
  end
  
  return sum
end

return module

-- print(spreadSheetChecksum(hash))
