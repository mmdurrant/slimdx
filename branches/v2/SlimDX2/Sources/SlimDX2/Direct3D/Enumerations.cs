// Copyright (c) 2007-2010 SlimDX Group
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

//------------------------------------------------------------------------------
// <auto-generated>
//     Enums for SlimDX2.Direct3D namespace.
//     This code was generated by a tool.
//     Date : 10/25/2010 14:26:42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

namespace SlimDX2.Direct3D {

    
    /// <summary>	
    /// Driver type options.	
    /// </summary>	
    /// <remarks>	
    /// The driver type is required when calling <see cref="SlimDX2.Direct3D11.D3D11.CreateDevice"/> or <see cref="SlimDX2.Direct3D11.D3D11.CreateDeviceAndSwapChain"/>.	
    /// </remarks>	
    /// <unmanaged>D3D_DRIVER_TYPE</unmanaged>
    public enum DriverType : int {	
        
        /// <summary>	
        /// The driver type is unknown.	
        /// </summary>	
        /// <unmanaged>D3D_DRIVER_TYPE_UNKNOWN</unmanaged>
        Unknown = unchecked((int)0),			
        
        /// <summary>	
        /// A hardware driver, which implements Direct3D features in hardware. This is the primary driver that you should use in your Direct3D applications because it provides the best performance. A hardware driver uses hardware acceleration (on supported hardware) but can also use software for parts of the pipeline that are not supported in hardware. This driver type is often referred to as a hardware abstraction layer or HAL.	
        /// </summary>	
        /// <unmanaged>D3D_DRIVER_TYPE_HARDWARE</unmanaged>
        Hardware = unchecked((int)(0+1)),			
        
        /// <summary>	
        /// A reference driver, which is a software implementation that supports every Direct3D feature. A reference driver is designed for accuracy rather than speed and as a result is slow but accurate. The rasterizer portion of the driver does make use of special CPU instructions whenever it can, but it is not intended for retail applications; use it only for feature testing, demonstration of functionality, debugging, or verifying bugs in other drivers. This driver is installed by the DirectX SDK. This driver may be referred to as a REF driver, a reference driver or a reference rasterizer.	
        /// </summary>	
        /// <unmanaged>D3D_DRIVER_TYPE_REFERENCE</unmanaged>
        Reference = unchecked((int)((0+1)+1)),			
        
        /// <summary>	
        /// A NULL driver, which is a reference driver without render capability. This driver is commonly used for debugging non-rendering API calls, it is not appropriate for retail applications. This driver is installed by the DirectX SDK.	
        /// </summary>	
        /// <unmanaged>D3D_DRIVER_TYPE_NULL</unmanaged>
        Null = unchecked((int)(((0+1)+1)+1)),			
        
        /// <summary>	
        /// A software driver, which is a driver implemented completely in software. The software implementation is not intended for a high-performance application due to its very slow performance.	
        /// </summary>	
        /// <unmanaged>D3D_DRIVER_TYPE_SOFTWARE</unmanaged>
        Software = unchecked((int)((((0+1)+1)+1)+1)),			
        
        /// <summary>	
        /// A WARP driver, which is a high-performance software rasterizer. The rasterizer supports {{feature levels}} 9_1 through level 10.1 with a high performance software implementation. For information about limitations creating a WARP device on certain feature levels, see {{Limitations Creating WARP and Reference Devices}}. For more information about using a WARP driver, see {{Windows Advanced Rasterization Platform (WARP) In-Depth Guide}}	
        /// </summary>	
        /// <unmanaged>D3D_DRIVER_TYPE_WARP</unmanaged>
        Warp = unchecked((int)(((((0+1)+1)+1)+1)+1)),			
    }
    
    /// <summary>	
    /// Describes the set of features targeted by a Direct3D device.	
    /// </summary>	
    /// <remarks>	
    /// See {{Overview For Each Feature Level}} for an overview of  the capabilities of each feature level.For information about limitations creating nonhardware-type devices on certain feature levels, see {{Limitations Creating WARP and Reference Devices}}.	
    /// </remarks>	
    /// <unmanaged>D3D_FEATURE_LEVEL</unmanaged>
    public enum FeatureLevel : int {	
        
        /// <summary>	
        /// Targets features supported by Direct3D 9.1 including shader model 2.	
        /// </summary>	
        /// <unmanaged>D3D_FEATURE_LEVEL_9_1</unmanaged>
        Level_9_1 = unchecked((int)0x9100),			
        
        /// <summary>	
        /// Targets features supported by Direct3D 9.2 including shader model 2.	
        /// </summary>	
        /// <unmanaged>D3D_FEATURE_LEVEL_9_2</unmanaged>
        Level_9_2 = unchecked((int)0x9200),			
        
        /// <summary>	
        /// Targets features supported by Direct3D 9.3 including shader shader model 3.	
        /// </summary>	
        /// <unmanaged>D3D_FEATURE_LEVEL_9_3</unmanaged>
        Level_9_3 = unchecked((int)0x9300),			
        
        /// <summary>	
        /// Targets features supported by Direct3D 10.0 including shader shader model 4.	
        /// </summary>	
        /// <unmanaged>D3D_FEATURE_LEVEL_10_0</unmanaged>
        Level_10_0 = unchecked((int)0xa000),			
        
        /// <summary>	
        /// Targets features supported by Direct3D 10.1 including shader shader model 4.	
        /// </summary>	
        /// <unmanaged>D3D_FEATURE_LEVEL_10_1</unmanaged>
        Level_10_1 = unchecked((int)0xa100),			
        
        /// <summary>	
        /// Targets features supported by Direct3D 11.0 including shader shader model 5.	
        /// </summary>	
        /// <unmanaged>D3D_FEATURE_LEVEL_11_0</unmanaged>
        Level_11_0 = unchecked((int)0xb000),			
    }
    
    /// <summary>	
    /// Values that indicate how the pipeline interprets vertex data that is bound to the input-assembler stage. These primitive topology values determine how the vertex data is rendered on screen.	
    /// </summary>	
    /// <remarks>	
    /// Use the  <see cref="SlimDX2.Direct3D11.DeviceContext.InputAssemblerStage.SetPrimitiveTopology"/> method and a value from D3D_PRIMITIVE_TOPOLOGY to bind a primitive topology to the input-assembler stage. Use the  <see cref="SlimDX2.Direct3D11.DeviceContext.InputAssemblerStage.GetPrimitiveTopology"/> method to retrieve the primitive topology for the input-assembler stage.	
    /// </remarks>	
    /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY</unmanaged>
    public enum PrimitiveTopology : int {	
        
        /// <summary>	
        /// The IA stage has not been initialized with a primitive topology. The IA stage will not function properly unless a primitive topology is defined.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_UNDEFINED</unmanaged>
        Undefined = unchecked((int)0),			
        
        /// <summary>	
        /// Interpret the vertex data as a list of points.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_POINTLIST</unmanaged>
        Pointlist = unchecked((int)1),			
        
        /// <summary>	
        /// Interpret the vertex data as a list of lines.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_LINELIST</unmanaged>
        Linelist = unchecked((int)2),			
        
        /// <summary>	
        /// Interpret the vertex data as a line strip.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_LINESTRIP</unmanaged>
        Linestrip = unchecked((int)3),			
        
        /// <summary>	
        /// Interpret the vertex data as a list of triangles.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST</unmanaged>
        Trianglelist = unchecked((int)4),			
        
        /// <summary>	
        /// Interpret the vertex data as a triangle strip.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP</unmanaged>
        Trianglestrip = unchecked((int)5),			
        
        /// <summary>	
        /// Interpret the vertex data as a list of lines with adjacency data.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ</unmanaged>
        LinelistWithAdjency = unchecked((int)10),			
        
        /// <summary>	
        /// Interpret the vertex data as a line strip with adjacency data.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ</unmanaged>
        LinestripWithAdjency = unchecked((int)11),			
        
        /// <summary>	
        /// Interpret the vertex data as a list of triangles with adjacency data.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ</unmanaged>
        TrianglelistWithAdjency = unchecked((int)12),			
        
        /// <summary>	
        /// Interpret the vertex data as a triangle strip with adjacency data.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ</unmanaged>
        TrianglestripWithAdjency = unchecked((int)13),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith1ControlPoints = unchecked((int)33),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith2ControlPoints = unchecked((int)34),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith3ControlPoints = unchecked((int)35),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith4ControlPoints = unchecked((int)36),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith5ControlPoints = unchecked((int)37),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith6ControlPoints = unchecked((int)38),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith7ControlPoints = unchecked((int)39),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith8ControlPoints = unchecked((int)40),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith9ControlPoints = unchecked((int)41),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith10ControlPoints = unchecked((int)42),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith11ControlPoints = unchecked((int)43),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith12ControlPoints = unchecked((int)44),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith13ControlPoints = unchecked((int)45),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith14ControlPoints = unchecked((int)46),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith15ControlPoints = unchecked((int)47),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith16ControlPoints = unchecked((int)48),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith17ControlPoints = unchecked((int)49),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith18ControlPoints = unchecked((int)50),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith19ControlPoints = unchecked((int)51),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith20ControlPoints = unchecked((int)52),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith21ControlPoints = unchecked((int)53),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith22ControlPoints = unchecked((int)54),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith23ControlPoints = unchecked((int)55),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith24ControlPoints = unchecked((int)56),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith25ControlPoints = unchecked((int)57),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith26ControlPoints = unchecked((int)58),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith27ControlPoints = unchecked((int)59),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith28ControlPoints = unchecked((int)60),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith29ControlPoints = unchecked((int)61),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith30ControlPoints = unchecked((int)62),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith31ControlPoints = unchecked((int)63),			
        
        /// <summary>	
        /// Interpret the vertex data as a patch list.	
        /// </summary>	
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST</unmanaged>
        PatchListWith32ControlPoints = unchecked((int)64),			
    }
    
    /// <summary>	
    /// Values that identify the type of resource to be viewed as a shader resource.	
    /// </summary>	
    /// <remarks>	
    /// A D3D_SRV_DIMENSION-typed value is specified in the ViewDimension member of the <see cref="SlimDX2.Direct3D11.ShaderResourceViewDescription"/> structure or the  Dimension member of the <see cref="SlimDX2.D3DCompiler.ShaderInputBindDescription"/> structure.	
    /// </remarks>	
    /// <unmanaged>D3D_SRV_DIMENSION</unmanaged>
    public enum ShaderResourceViewDimension : int {	
        
        /// <summary>	
        /// The type is unknown.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_UNKNOWN</unmanaged>
        Unknown = unchecked((int)0),			
        
        /// <summary>	
        /// The resource is a buffer.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_BUFFER</unmanaged>
        Buffer = unchecked((int)1),			
        
        /// <summary>	
        /// The resource is a 1D texture.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE1D</unmanaged>
        Texture1D = unchecked((int)2),			
        
        /// <summary>	
        /// The resource is an array of 1D textures.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE1DARRAY</unmanaged>
        Texture1DArray = unchecked((int)3),			
        
        /// <summary>	
        /// The resource is a 2D texture.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE2D</unmanaged>
        Texture2D = unchecked((int)4),			
        
        /// <summary>	
        /// The resource is an array of 2D textures.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE2DARRAY</unmanaged>
        Texture2DArray = unchecked((int)5),			
        
        /// <summary>	
        /// The resource is a multisampling 2D texture.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE2DMS</unmanaged>
        Texture2DMultisampled = unchecked((int)6),			
        
        /// <summary>	
        /// The resource is an array of multisampling 2D textures.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE2DMSARRAY</unmanaged>
        Texture2DMultisampledArray = unchecked((int)7),			
        
        /// <summary>	
        /// The resource is a 3D texture.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE3D</unmanaged>
        Texture3D = unchecked((int)8),			
        
        /// <summary>	
        /// The resource is a cube texture.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURECUBE</unmanaged>
        Texturecube = unchecked((int)9),			
        
        /// <summary>	
        /// The resource is an array of cube textures.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURECUBEARRAY</unmanaged>
        Texturecubearray = unchecked((int)10),			
        
        /// <summary>	
        /// The resource is an extended buffer.	
        /// </summary>	
        /// <unmanaged>D3D_SRV_DIMENSION_BUFFEREX</unmanaged>
        ExtendedBuffer = unchecked((int)11),			
    }
}
