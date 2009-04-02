#include "stdafx.h"
/*
* Copyright (c) 2007-2009 SlimDX Group
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

#include <dxgi.h>

#include <vector>

#include "DXGIException.h"

#include "FrameStatistics.h"
#include "GammaControl.h"
#include "GammaControlCapabilities.h"
#include "ModeDescription.h"
#include "Output.h"
#include "OutputDescription.h"
#include "Surface.h"

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Collections::ObjectModel;

namespace SlimDX
{
namespace DXGI
{ 	
	OutputDescription Output::Description::get()
	{
		DXGI_OUTPUT_DESC nativeDescription;
		RECORD_DXGI( InternalPointer->GetDesc( &nativeDescription ) );
		if( Result::Last.IsSuccess )
			return OutputDescription( nativeDescription );
		
		throw gcnew DXGIException( Result::Last );
	}
	
	DXGI::FrameStatistics Output::FrameStatistics::get()
	{
		DXGI_FRAME_STATISTICS stats;
		RECORD_DXGI( InternalPointer->GetFrameStatistics( &stats ) );
		if( Result::Last.IsSuccess )
			return DXGI::FrameStatistics( stats );
		
		throw gcnew DXGIException( Result::Last );
	}
	
	DXGI::GammaControlCapabilities Output::GammaControlCapabilities::get()
	{
		DXGI_GAMMA_CONTROL_CAPABILITIES caps;
		RECORD_DXGI( InternalPointer->GetGammaControlCapabilities( &caps ) );
		if( Result::Last.IsSuccess )
			return DXGI::GammaControlCapabilities( caps );
		
		throw gcnew DXGIException( Result::Last );
	}
	
	ReadOnlyCollection<ModeDescription>^ Output::GetDisplayModeList( Format format, DisplayModeEnumerationFlags flags )
	{
		UINT modeCount = 0;
		RECORD_DXGI( InternalPointer->GetDisplayModeList( static_cast<DXGI_FORMAT>( format ), static_cast<UINT>( flags ), &modeCount, 0 ) );
		if( Result::Last.IsFailure || modeCount == 0 )
			return nullptr;
		
		std::vector<DXGI_MODE_DESC> nativeDescriptions(modeCount);
		RECORD_DXGI( InternalPointer->GetDisplayModeList( static_cast<DXGI_FORMAT>( format ), static_cast<UINT>( flags ), &modeCount, &nativeDescriptions[0] ) );
		if( Result::Last.IsFailure )
			return nullptr;
		
		List<ModeDescription>^ descriptions = gcnew List<ModeDescription>( modeCount );
		for( unsigned int descriptionIndex = 0; descriptionIndex < nativeDescriptions.size(); ++descriptionIndex )
			descriptions->Add( ModeDescription( nativeDescriptions[ descriptionIndex ] ) );
		
		return gcnew ReadOnlyCollection<ModeDescription>( descriptions );
	}
	
	Result Output::GetClosestMatchingMode( ComObject^ device, ModeDescription modeToMatch, [Out] ModeDescription% result )
	{
		if( device == nullptr )
			throw gcnew System::ArgumentNullException( "device" );
			
		DXGI_MODE_DESC nativeModeToMatch = modeToMatch.CreateNativeVersion();
		DXGI_MODE_DESC nativeResult;
		RECORD_DXGI( InternalPointer->FindClosestMatchingMode( &nativeModeToMatch, &nativeResult, device->UnknownPointer ) );
		if( Result::Last.IsSuccess )
			result = ModeDescription( nativeResult );
		return Result::Last;
	}
	
	Result Output::SetGammaControl( GammaControl control )
	{
		DXGI_GAMMA_CONTROL nativeControl = control.CreateNativeVersion();
		return RECORD_DXGI( InternalPointer->SetGammaControl( &nativeControl ) );
	}
	
	Result Output::SetDisplaySurface( ISurface^ surface )
	{
		if( surface == nullptr )
			throw gcnew System::ArgumentNullException( "surface" );
		return RECORD_DXGI( InternalPointer->SetDisplaySurface( surface->InternalPointer ) );
	}
	
	Result Output::CopyDisplaySurfaceTo( ISurface^ surface )
	{
		if( surface == nullptr )
			throw gcnew System::ArgumentNullException( "surface" );
		return RECORD_DXGI( InternalPointer->GetDisplaySurfaceData( surface->InternalPointer ) );
	}
	
	Result Output::TakeOwnership( ComObject^ device, bool exclusive )
	{
		if( device == nullptr )
			throw gcnew System::ArgumentNullException( "device" );
		return RECORD_DXGI( InternalPointer->TakeOwnership( device->UnknownPointer, exclusive ) );
	}
	
	void Output::ReleaseOwnership()
	{
		InternalPointer->ReleaseOwnership();
	}
	
	Result Output::WaitForVerticalBlank()
	{
		return RECORD_DXGI( InternalPointer->WaitForVBlank() );
	}
	
	String^ Output::ToString() {
		return Description.Name;
	}
}
}
