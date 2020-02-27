-- Generated by CSharp.lua Compiler
local System = System
local ICSharpCodeCompression = ICSharpCode.SharpZipLib.Zip.Compression
local SystemIO = System.IO
local ArrayByte = System.Array(System.Byte)
System.namespace("DCET", function (namespace)
  namespace.class("ZipHelper", function (namespace)
    local Compress, Decompress, Decompress1
    Compress = function (content)
      --return content;
      local compressor = ICSharpCodeCompression.Deflater()
      compressor:SetLevel(9 --[[Deflater.BEST_COMPRESSION]])

      compressor:SetInput(content)
      compressor:Finish()

      local default, extern = System.using(SystemIO.MemoryStream(#content), function (bos)
        local buf = ArrayByte:new(1024)
        while not compressor:getIsFinished() do
          local n = compressor:Deflate(buf)
          bos:Write(buf, 0, n)
        end
        return true, bos:ToArray()
      end)
      if default then
        return extern
      end
    end
    Decompress = function (content)
      return Decompress1(content, 0, #content)
    end
    Decompress1 = function (content, offset, count)
      --return content;
      local decompressor = ICSharpCodeCompression.Inflater()
      decompressor:SetInput(content, offset, count)

      local default, extern = System.using(SystemIO.MemoryStream(#content), function (bos)
        local buf = ArrayByte:new(1024)
        while not decompressor:getIsFinished() do
          local n = decompressor:Inflate(buf)
          bos:Write(buf, 0, n)
        end
        return true, bos:ToArray()
      end)
      if default then
        return extern
      end
    end
    return {
      Compress = Compress,
      Decompress = Decompress,
      Decompress1 = Decompress1
    }
  end)
end)